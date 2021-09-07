using System;
using System.Collections.Generic;
namespace Data_Structures
{
    public class DataStructures
    {
        static void Main(string[] args)
        {
            var tree = new Tree.BinarySearchTree();

            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(6);
            tree.Insert(9);

            tree.TraverseInOrder();
            Console.WriteLine(tree.Min());
        }
    }
}
