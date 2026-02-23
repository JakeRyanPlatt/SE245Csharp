// Jake Platt
// SE245
// 2/4/2026
// This program demonstrates a Person class with property-based validation
using System;
using System.Windows.Forms;


namespace MidTermAssignment
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

