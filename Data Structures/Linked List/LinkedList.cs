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
            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
        private Node first;
        private Node last;

        private bool IsEmpty()
        {
            return first == null;
        }

        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }

        }
        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }
    }
}


