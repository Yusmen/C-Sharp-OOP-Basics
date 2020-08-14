using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings:List<string>
    {
        public void Push(string element)
        {
            Add(element);

        }
        public string Pop()
        {
            string element = GetLastString();
            this.RemoveAt(Count - 1);
            return element;
        }

        public string Peek()
        {
            return GetLastString();

        }
        public bool isEmpty()
        {
            return Count < 1;

        }

        private string GetLastString()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("The stack is Empty");
            }
            return this.Last();
        }
            

    }
}
