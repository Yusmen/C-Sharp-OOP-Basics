using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection:List<string>,IAddCollection
    {



        public int AddElement(string element)
        {
            this.Add(element);
            return this.Count-1;
        }
    }
}
