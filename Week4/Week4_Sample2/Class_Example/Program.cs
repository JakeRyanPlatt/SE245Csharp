// Jake Platt
// January 22, 2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Week4_Class1
{
    public class Program
    {
        public class Book{
            private string title;
            private string authorLastName;
            private string email;
            private DateTime datePublished;
            private int pages;
            private double price;

            public string Title
            {
                get { return title; }
                set { title = value; }
            }
            public  string Author { get; set; }

            public  string AuthorLastName
            {
                get { return authorLastName; }
                set { authorLastName = value; }
            }
            public  string Email
            {
                get { return email; }
                set { email = value; }
            }

            public DateTime DatePublished
            {
                get { return datePublished; }
                set { datePublished = value; }
            }

            public int Pages
            {
                get { return pages; }
                set { pages = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }

            static void Main(string[] args)
            {
                bool blnResult = false;

                Book temp = new Book();

                Console.WriteLine("Enter the book title: ");
                temp.Title = Console.ReadLine();

                Console.WriteLine("Enter the author's first name: ");
                temp.Author = Console.ReadLine();

                Console.WriteLine("Enter the author's last name: ");
                temp.AuthorLastName = Console.ReadLine();

                Console.WriteLine("Enter the author's email: ");
                temp.Email = Console.ReadLine();

                do
                {
                    Console.WriteLine("Enter the date published (MM/DD/YYYY): ");
                    DateTime dtTempDate;
                    blnResult = DateTime.TryParse(Console.ReadLine(), out dtTempDate);

                    if (blnResult == false)
                    {
                        Console.WriteLine("Invalid date format. Please enter the date in MM/DD/YYYY format.\n(Ex: 10//31/2000");
                    }
                    else
                    {

                        temp.DatePublished = dtTempDate;
                    }

                } while (blnResult == false);

                do
                {
                    Console.WriteLine("Enter the number of pages: ");
                    int intTempPages;
                    blnResult = int.TryParse(Console.ReadLine(), out intTempPages);
                    if (blnResult == false || intTempPages < 1)
                    {
                        Console.WriteLine("Invalid number of pages. Please enter a positive integer.\n(Ex: 214");
                    }
                    else
                    {
                        temp.Pages = intTempPages;
                    }
                } while (blnResult == false);
                do
                {
                    Console.WriteLine("Enter the price: ");
                    double dblTempPrice;
                    blnResult = double.TryParse(Console.ReadLine(), out dblTempPrice);
                    if (blnResult == false || dblTempPrice < 0)
                    {
                        Console.WriteLine("Invalid price. Please enter a non-negative number.\n(Ex: 19.99");
                    }
                    else
                    {
                        temp.Price = dblTempPrice;
                    }
                } while (blnResult == false);
                Console.WriteLine("\nBook Information:");
                Console.WriteLine($"Title: {temp.Title}");
                Console.WriteLine($"Author: {temp.Author} {temp.AuthorLastName}");
                Console.WriteLine($"Email: {temp.Email}");
                Console.WriteLine($"Date Published: {temp.DatePublished.ToShortDateString()}");
                Console.WriteLine($"Pages: {temp.Pages}");
                Console.WriteLine($"Price: ${temp.Price:F2}");

            }
        }
    }
}