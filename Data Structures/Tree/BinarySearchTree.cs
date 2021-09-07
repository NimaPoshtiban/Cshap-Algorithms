using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Tree
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;
            public Node(int value)
            {
                this.value = value;
            }
        }
        private Node root;
        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return;
            }
            Node current = root;

            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = new Node(value);
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = new Node(value);
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public bool Find(int value)
        {
            var current = root;
            while (current != null)
            {
                if (value > current.value)
                {
                    current = current.rightChild;
                }
                else if (value < current.value)
                {
                    current = current.leftChild;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        // Searching the Tree using Depth first approach Pre-Order 
        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }
        private void TraversePreOrder(Node root)
        {
            if (root == null) return;
            Console.WriteLine(root.value);
            TraversePreOrder(root.leftChild);
            TraversePreOrder(root.rightChild);
        }

        // Searching the Tree using Depth first approach In-Order 
        // 

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }
        private void TraverseInOrder(Node root)
        {
            if (root == null) return;
            TraverseInOrder(root.leftChild);
            Console.WriteLine(root.value);
            TraverseInOrder(root.rightChild);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }
        private void TraversePostOrder(Node root)
        {
            if (root == null) return;
            TraversePostOrder(root.leftChild);
            TraversePostOrder(root.rightChild);
            Console.WriteLine(root.value);
        }

        // CalCulating the height of a tree
        public int Height()
        {
            return Height(root);
        }
        private int Height(Node root)
        {
            if (root.leftChild == null && root.rightChild == null) return 0;

            return 1 + Math.Max(Height(root.rightChild), Height(root.leftChild));
        }


    }
}
