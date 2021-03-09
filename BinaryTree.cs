using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAp0
{
    class BinaryTree
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }
        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }
        public void PreorderTraversal()
        {
            if (root != null)
                root.PreOrderTraversal();
        }
        public void PostorderTraversal()
        {
            if (root != null)
                root.PostorderTraversal();
        }
        public int Height()
        {
            if (root == null)
            { return 0; }

            return root.Height();
        }
        public bool IsBalanced()
        {
            if (root == null)
            {
                return true;
            }

            return root.IsBalanced();
        }

    }
}
