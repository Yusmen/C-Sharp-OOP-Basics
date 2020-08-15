using System;

namespace CollectionHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] elements = Console.ReadLine().Split();
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            Addding(addCollection,elements.Length,elements);
            Console.WriteLine();
            Addding(addRemoveCollection,elements.Length,elements);
            Console.WriteLine();
            Addding(myList,elements.Length,elements);
            Console.WriteLine();
           
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(addRemoveCollection.RemoveElement()+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(myList.RemoveElement()+" ");
            }

      

        

     
          
         

        }

        private static void Addding(MyList myList, int length, string[] elements)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(myList.AddElement(elements[i]) + " ");
            }
        }

        private static void Addding(AddRemoveCollection addRemoveCollection, int length, string[] elements)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(addRemoveCollection.AddElement(elements[i]) + " ");
            }
        }

        private static void Addding(AddCollection addCollection,int n,string[] elements)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(addCollection.AddElement(elements[i]) + " ");
            }
        }
    }
}
