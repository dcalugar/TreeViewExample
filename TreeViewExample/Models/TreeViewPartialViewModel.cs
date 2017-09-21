using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeViewExample.Models
{
    public class TreeViewPartialViewModel
    {
        public TreeViewPartialViewModel(int uniqueTreeViewId)
        {
            MasterTreeNode = new List<TreeNode<Link>>();
            this.TreeViewId = uniqueTreeViewId;
        }

        public int TreeViewId { get; set; }


        public List<TreeNode<Link>> MasterTreeNode { get; set; }
    }
}
