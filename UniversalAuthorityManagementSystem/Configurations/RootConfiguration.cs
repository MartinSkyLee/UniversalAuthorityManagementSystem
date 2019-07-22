using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalAuthorityManagementSystem.Configurations
{
    public class RootConfiguration: IRootConfiguration
    {
        public ISwaggerWithOAuth2Scheme SwaggerWithOAuth2Scheme { get; set; }

        public RootConfiguration(IOptions<SwaggerWithOAuth2Scheme> swaggerWithOAuth2Scheme)
        {
            SwaggerWithOAuth2Scheme = swaggerWithOAuth2Scheme.Value;
        }
    }
}
