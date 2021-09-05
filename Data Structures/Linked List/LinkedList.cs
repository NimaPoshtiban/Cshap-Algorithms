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
        private int size;

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
            size++;
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
            size++;
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

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new Exception(" No Such element ");

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var second = first.next;
                first.next = null;
                first.next = second;
            }

            size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new Exception(" No Such element ");

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var privous = GetPrevious(last);
                last = privous;
                last.next = null;
            }

            size--;
        }
        // returns previous node
        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        }

        public int Size()
        {
            return size;
        }
    }
}


