using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public interface IMyList
    {
        int AddElement(string element);
        string RemoveElement();
        int Used();

    }
}
