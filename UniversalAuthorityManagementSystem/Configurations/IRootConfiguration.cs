using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalAuthorityManagementSystem.Configurations
{
    public interface IRootConfiguration
    {
        ISwaggerWithOAuth2Scheme SwaggerWithOAuth2Scheme { get; }
    }
}
