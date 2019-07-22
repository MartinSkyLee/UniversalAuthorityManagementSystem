using AutoMapper;
using System.Collections.Generic;
using System.IO;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using UniversalAuthorityManagement.Models.DBEntities;
using UniversalAuthorityManagementSystem.Configurations;
using UniversalAuthorityManagement.Service.Interface;
using UniversalAuthorityManagement.Service.Service;
using UniversalAuthorityManagement.Models;
using System;
using DHSurvey.Common.Helper;

namespace UniversalAuthorityManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var connection = Configuration.GetConnectionString("MySqlConnection");
            services.AddDbContext<UniversalAuthorityManagementContext>(options => options.UseMySQL(connection));

            services.AddScoped<IAppService, AppService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IPermissionService, PermissionService>();

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
               .AddIdentityServerAuthentication(options =>
               {
                   options.Authority = Configuration.GetSection("AuthenticationOptions:Authority").Value; // IdentityServer服务器地址
                   options.ApiName = Configuration.GetSection("AuthenticationOptions:ApiName").Value; // 用于针对进行身份验证的API资源的名称
                   options.RequireHttpsMetadata = Convert.ToBoolean(Configuration.GetSection("AuthenticationOptions:RequireHttpsMetadata").Value); // 指定是否为HTTPS
               });

            #region 配置跨域资源共享服务
            string[] urls = Configuration.GetSection("AllowCors:AllowAllOrigin").Value.Split(",");
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigin", builder =>
                {
                    builder.WithOrigins(urls)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowAnyOrigin()
                    .AllowCredentials();
                });
            });
            #endregion

            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            //services.AddAuthentication(options =>
            //    {
            //        options.DefaultScheme = "Cookies";
            //        options.DefaultChallengeScheme = "oidc";
            //    })
            //    .AddCookie("Cookies")
            //    .AddOpenIdConnect("oidc", options =>
            //    {
            //        options.Authority = "http://localhost:5000";
            //        options.RequireHttpsMetadata = false;

            //        options.ClientId = "client_api_swagger";
            //        options.SaveTokens = true;
            //    });

            #region 配置读取配置文件
            services.AddOptions();
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            #endregion

            //配置Redis
            RedisConfig.Connection = Configuration.GetSection("RedisConfig:Connection").Value;
            RedisConfig.DefaultDatabase = Convert.ToInt32(Configuration.GetSection("RedisConfig:DefaultDatabase").Value);
            RedisConfig.InstanceName = Configuration.GetSection("RedisConfig:InstanceName").Value;
            CommonManager.CacheObj.GetMessage<RedisCacheHelper>();

            services.AddAutoMapper();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //从appsettings获取swagger配置
            services.AddOptions();
            services.Configure<SwaggerWithOAuth2Scheme>(Configuration.GetSection("SwaggerWithOAuth2Scheme"));
            services.AddSingleton<IRootConfiguration, RootConfiguration>();
            var rootConfiguration = services.BuildServiceProvider().GetService<IRootConfiguration>();
            //注册Swagger生成器，定义一个和多个Swagger 文档
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "通用权限管理系统 API"
                });
                // 为 Swagger JSON and UI设置xml文档注释路径
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);//获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）
                var xmlPath = Path.Combine(basePath, "Swagger.xml");
                c.IncludeXmlComments(xmlPath);

                //向生成的Swagger添加一个或多个“securityDefinitions”，用于API的登录校验
                c.AddSecurityDefinition("oauth2", new OAuth2Scheme
                {
                    Flow = rootConfiguration.SwaggerWithOAuth2Scheme.Flow, // 只需通过浏览器获取令牌（适用于swagger）
                    AuthorizationUrl = rootConfiguration.SwaggerWithOAuth2Scheme.AuthorizationUrl,//获取登录授权接口
                    Scopes = rootConfiguration.SwaggerWithOAuth2Scheme.Scopes//指定客户端请求的api作用域。 如果为空，则客户端无法访问
                });

                c.OperationFilter<AuthorizeCheckOperationFilter>(); // 添加IdentityServer4认证过滤
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //使用允许跨域请求
            app.UseCors("AllowAllOrigin");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            #region 配置swagger
            //启用中间件服务生成Swagger作为JSON终结点
            app.UseSwagger();
            //启用中间件服务对swagger-ui，指定Swagger JSON终结点
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.OAuthClientId("client_api_swagger");//客服端名称
                //c.OAuthClientId("develop_api_swagger");
                c.OAuthAppName("通用权限管理系统 API"); // 描述
            });
            #endregion

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
