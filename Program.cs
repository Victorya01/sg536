using System;
using System.Collections.Generic;

namespace ConsoleAp0
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);
            binaryTree.Insert(100);
            Console.WriteLine("\nPre Order Traversal (Root->Left->Right)");
            binaryTree.PreorderTraversal();
            Console.WriteLine("\nPost Order Traversal (Left->Right->Root)");
            binaryTree.PostorderTraversal();

        }
    }
}
