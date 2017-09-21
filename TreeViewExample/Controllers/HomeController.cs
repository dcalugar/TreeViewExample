using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreeViewExample.Models;

namespace TreeViewExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel();

            model.MainNav = new TreeViewPartialViewModel(1);
            model.SubNav = new TreeViewPartialViewModel(2);

            #region test data
            TreeNode<Link> root1 = new TreeNode<Link>(new Link("Nicaragua"));
            TreeNode<Link> root2 = new TreeNode<Link>(new Link("Argentina"));
            TreeNode<Link> root3 = new TreeNode<Link>(new Link("Costa Rica"));

            TreeNode<Link> root = new TreeNode<Link>(new Link("USA"));
            {
                TreeNode<Link> node0 = root.AddChild(new Link("Florida"));
                {
                    TreeNode<Link> node01 = node0.AddChild(new Link("Miami"));
                    TreeNode<Link> node02 = node0.AddChild(new Link("Orlando"));
                    TreeNode<Link> node03 = node0.AddChild(new Link("Tampa"));
                    TreeNode<Link> node04 = node0.AddChild(new Link("Jacksonville"));
                    {
                        TreeNode<Link> node10 = node04.AddChild(new Link("Southside"));
                    }
                }
                TreeNode<Link> node1 = root.AddChild(new Link("Georgia"));
                {
                    TreeNode<Link> node11 = node1.AddChild(new Link("Atlanta"));

                }
            }
            #endregion test data


            model.MainNav.MasterTreeNode.Add(root1);
            model.MainNav.MasterTreeNode.Add(root2);
            model.MainNav.MasterTreeNode.Add(root3);
            model.MainNav.MasterTreeNode.Add(root);
            model.SubNav.MasterTreeNode.Add(root1);
            model.SubNav.MasterTreeNode.Add(root2);
            model.SubNav.MasterTreeNode.Add(root3);
            model.SubNav.MasterTreeNode.Add(root);

            return View(model);
        }
    }
}
