using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagementSystem.Configurations
{
    public class SwaggerWithOAuth2Scheme : ISwaggerWithOAuth2Scheme
    {
        public string Flow { get; set; } 

        public string AuthorizationUrl { get; set; }

        public Dictionary<string, string> Scopes { get; set; }
    }
}
