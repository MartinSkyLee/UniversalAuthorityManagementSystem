using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniversalAuthorityManagement.Models.Query
{
    public class QueryRoleParameters : QueryParameters
    {
        [Required]
        public int AppId { get; set; }
    }
}
