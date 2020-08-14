using System;

namespace BookShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                Book book = new Book(title, author, price);

                GoldenEditionBook goldenBook = new GoldenEditionBook(title, author, price);
                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenBook);

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


        }
    }
}
