using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalAuthorityManagement.Models.ViewModels.AppVM
{
    public class AppWithRoleTreeViewModel
    {
        public string Title { get; set; }
        public int Value { get; set; }
        public int Key { get; set; }
        public List<ChildNode> Children { get; set; } = new List<ChildNode>();
    }

    public class ChildNode
    {
        public string Title { get; set; }
        public int Value { get; set; }
        public int Key { get; set; }
        public bool IsLeaf { get; set; } = true;
    }
}
