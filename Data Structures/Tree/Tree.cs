using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Tree
{
    public class Tree
    {
        private class Node
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
    }
}
