using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection:List<string>,IAddRemoveCollection
    {

        public int AddElement(string element)
        {
            this.Insert(0, element);
            return this.IndexOf(element);
        }

        public string RemoveElement()
        {
            string element = this[Count - 1];
             this.RemoveAt(this.Count - 1);

            return element;
        }
            
    }
}
