using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAp0
{
    class TreeNode
    {
        private int data;
        public int Data
        {
            get { return data; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }
        public TreeNode(int value)
        {
            data = value;
        }
        public void Insert(int value)
        {
            if (value >= data)
            {
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }


        }
        public void PreOrderTraversal()
        {

            Console.Write(data + " ");


            if (leftNode != null)
                leftNode.PreOrderTraversal();


            if (rightNode != null)
                rightNode.PreOrderTraversal();
        }


        public void PostorderTraversal()
        {

            if (leftNode != null)
                leftNode.PostorderTraversal();


            if (rightNode != null)
                rightNode.PostorderTraversal();


            Console.Write(data + " ");
        }


        public int Height()
        {

            if (this.leftNode == null && this.rightNode == null)
            {
                return 1;
            }

            int left = 0;
            int right = 0;


            if (this.leftNode != null)
                left = this.leftNode.Height();
            if (this.rightNode != null)
                right = this.rightNode.Height();


            if (left > right)
            {
                return (left + 1);
            }
            else
            {
                return (right + 1);
            }
        }
        public bool IsBalanced()
        {
            int LeftHeight = LeftNode != null ? LeftNode.Height() : 0;
            int RightHeight = RightNode != null ? RightNode.Height() : 0;

            int heightDifference = LeftHeight - RightHeight;

            if (Math.Abs(heightDifference) > 1)
            {
                return false;
            }
            else
            {
                return ((LeftNode != null ? LeftNode.IsBalanced() : true) && (RightNode != null ? RightNode.IsBalanced() : true));
            }
        }
    }
}
