using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagementSystem.Configurations
{
    public interface ISwaggerWithOAuth2Scheme
    {
        string Flow { get;}

        string AuthorizationUrl { get;}

        Dictionary<string, string> Scopes { get;}
    }
}
