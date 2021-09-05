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

        public int[] ToArray()
        {
            int[] array = new int[size];
            var current = first;
            var index = 0;
            while (current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }
            return array;
        }
        // an algorithm for reversing a single linked list
        public void Reverse()
        {
            //[1->2->3]
            // p  c  n 
            var privous = first;
            var current = first.next;


            while (current != null)
            {
                var next = current.next;
                current.next = privous;
                privous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = privous;
        }

        //an Algorithm for getting values basded on their distance from the Tail
        public int GetKthFromTheEnd(int k)
        {
            if (k == 0) return last.value;

            var firstPointer = first;
            var secondPointer = first;

            for (int i = 1; i <= k; i++)
            {
                if (secondPointer == null) throw new Exception("Invalid Number, Number is out of range");
                secondPointer = secondPointer.next;
            }

            while (secondPointer != last)
            {
                firstPointer = firstPointer.next;
                secondPointer = secondPointer.next;
            }
            return firstPointer.value;
        }
    }
}


