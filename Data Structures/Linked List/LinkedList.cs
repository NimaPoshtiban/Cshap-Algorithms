using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Linked_List
{
    public class LinkedList
    {
        private class Node
        {
            private int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
        private Node first;
        private Node last;
        public void AddLast(int item)
        {
            var node = new Node(item);

            if (first == null)
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }

        }
    }
}


