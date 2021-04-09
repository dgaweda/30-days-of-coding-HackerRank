using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    class MyBook : Book // MyBook Class that inherits title and author values form Book
    {
        private int price; // Price - MyBook class value (not inherited)

        public MyBook(string title, string author, int price) // Constructor takes all 3 values
            : base(title, author) // title and author values from Book CLASS
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override void display() // need to override method because of display() in Book class
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }

}
