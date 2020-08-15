using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList:List<string>,IMyList
    {

        private int size;

        public int AddElement(string element)
        {
            this.Insert(0, element);
            size++;
            return this.IndexOf(element);
           
        }

        public string RemoveElement()
        {
            string element = this[0];
            this.RemoveAt(0);
            size--;
            return element;
        }

        public int Used()
        {
            return size;
        }
            
            
    }
}
