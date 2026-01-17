using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNum, strCntr;
            double dblNum = 0, dblTotal = 0, dblResult = 0;
            bool blnResult = false;

            Console.WriteLine(
                "Averager Program: how many week's earnings are you going to average?");
            strCntr = Console.ReadLine();

            int intCntr = Int32.Parse(strCntr);

            double[] dbEarnings = new double[intCntr];

            Console.WriteLine("Average Program: Enter weekly earnings.\n\n");

            for (int intCounter = 0; intCounter < intCntr; intCounter++)
            {
                do
                {
                    Console.WriteLine(
                        "Please enter payroll #" + (intCounter + 1) + ": ");
                    strNum = Console.ReadLine();

                    blnResult = Double.TryParse(strNum, out dblNum);

                    if (blnResult == false)
                    {
                        Console.WriteLine(
                            "\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00");
                    }
                } while (blnResult == false);

                dbEarnings[intCounter] = dblNum;
                dblTotal += dblNum;
            }

            dblResult = dblTotal / intCntr;
            Console.WriteLine("The average of the weekly earnings entered is: $" + dblResult);
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}