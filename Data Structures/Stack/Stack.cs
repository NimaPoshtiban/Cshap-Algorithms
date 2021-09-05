using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Stack
{
    public class Stack<T>
    {
        private T[] items;
        private int MaxLength;
        private int count;

        public int Length { get { return count; } }

        public Stack(int length)
        {
            items = new T[length];
            MaxLength = length;
            count = 0;
        }

        public void Push(T item)
        {
            if (count == MaxLength) throw new StackOverflowException();
            items[count] = item;
            count++;
        }

        public T Pop()
        {
            if (count == 0) throw new Exception("Stack is Empty");
            var removedItem = items[^1];
            items[^1] = default;
            count--;
            return removedItem;
        }

        public T Peek()
        {
            if (count == 0) throw new Exception("Stack is Empty");
            return items[count - 1];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
