using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public interface IAddRemoveCollection
    {

        int AddElement(string element);
        string RemoveElement();
    }
}
