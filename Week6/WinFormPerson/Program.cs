using System:
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_Class1;

namespace Week6_Sample_DataValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool btnResult = false;

            Book temp = new Book();

            Console.WriteLine("\nEnter the book title:");
            temp.Title = Console.ReadLine();

            Console.WriteLine("\nEnter the Author's First Name:");
            temp.AuthorFirstName = Console.ReadLine();

            Console.WriteLine("\nEnter the Author's Last Name:");
            temp.AuthorLastName = Console.ReadLine();

            Console.WriteLine("\nPlease enter the Author's Email:");
            temp.Email = Console.ReadLine();

            do
            {
                Console.WriteLine("\nPlease enter the Date Published (MM/DD/YYYY):");
                DateTime dtTempDate;
                blnResult = DateTime.TryParse(Console.Readline(), out dtTempDate);

                if (blnResult == false)
                {
                    Console.WriteLine("\nInvalid date format. Please try again.");
                }
                else
                                    {
                    temp.DatePublished = dtTempDate;
                }
            } while (blnResult == false);


            do
            {
                Console.WriteLine("\nPlease enter the number of pages:");
                int intTempPages;
                blnResult = Int32.TryParse(Console.Readline(), out intTempPages);

                if (blnResult == false)
                {
                    Console.WriteLine("\nInvalid number format. Please try again.");
                }
                else
                {
                    temp.Pages = intTempPages;
                }
            } while (blnResult == false);

            do
            {
                Console.WriteLine("\nPlease enter the price:");
                double decTempPrice;
                blnResult = Double.TryParse(Console.Readline(), out decTempPrice);
                if (blnResult == false)
                {
                    Console.WriteLine("\nInvalid price format. Please try again.");
                }
                else
                {
                    temp.Price = decTempPrice;
                }
            } while (blnResult == false);

            // Look for errors listed in feedback
            if (!temp.Feedback.Contains("Error:"))
            {
                Console.WriteLine("\nBook added successfully!");
                Console.WriteLine($"\nTitle: {temp.Title}\nAuthor: {temp.AuthorFirstName} {temp.AuthorLastName}\nEmail: {temp.Email}\nDate Published: {temp.DatePublished.ToShortDateString()}\nPages: {temp.Pages}\nPrice: {temp.Price:C}");
            }
            else
            {
                Console.WriteLine("\nBook could not be added due to the following errors:");
                Console.WriteLine(temp.Feedback);
            }

            Basic.Tools.Pause();
        }
    }
}