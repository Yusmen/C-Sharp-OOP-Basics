using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {

        private string title;
        private string author;
        private double price;


        public Book(string title, string author, double price)
        {

            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public virtual double Price
        {
            get { return price; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }


        public string Author
        {
            get { return author; }
            set
            {
                var split = value.Split();
                
                if(char.IsDigit(split[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }


        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                        
                }
                title = value;
            }
        }
       
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;


        }


    }
}
