using System;

namespace Lab4_FormValid
{
    public class Person
    {
        // private fields
        private string firstName = "";
        private string middleName = "";
        private string lastName = "";
        private string street1 = "";
        private string street2 = "";
        private string city = "";
        private string state = "";
        private string zip = "";
        private string phone = "";
        private string email = "";

        // public properties with validation

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (Validate.IsFilledIn(value))
                    firstName = value;
                else
                    throw new Exception("First name is required.");
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (Validate.IsFilledIn(value))
                    lastName = value;
                else
                    throw new Exception("Last name is required.");
            }
        }

        public string Street1
        {
            get { return street1; }
            set { street1 = value; }
        }

        public string Street2
        {
            get { return street2; }
            set { street2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set
            {
                // at least 5 characters
                if (Validate.IsMinLength(value, 5))
                    zip = value;
                else
                    throw new Exception("ZIP must be at least 5 characters long.");
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                // at least 10 characters
                if (Validate.IsMinLength(value, 10))
                    phone = value;
                else
                    throw new Exception("Phone must be at least 10 characters long.");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (Validate.IsValidEmail(value))
                    email = value;
                else
                    throw new Exception("Email is not in valid format.");
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            // These all go through the properties (validation)
            p.FirstName = "John";
            p.MiddleName = "Q";
            p.LastName = "Public";
            p.Street1 = "123 Main St";
            p.Street2 = "Apt 4B";
            p.City = "Somewhere";
            p.State = "CA";
            p.Zip = "90210";
            p.Phone = "5551234567";
            p.Email = "john.public@example.com";

            // Attempted "hack" now must satisfy the FirstName setter
            p.FirstName = p.FirstName + " - You've been hacked pal!";

            Console.WriteLine("Person data stored:");
            Console.WriteLine($"Name: {p.FirstName} {p.MiddleName} {p.LastName}");
            Console.WriteLine($"Address: {p.Street1}, {p.Street2}");
            Console.WriteLine($"{p.City}, {p.State} {p.Zip}");
            Console.WriteLine($"Phone: {p.Phone}");
            Console.WriteLine($"Email: {p.Email}");

            Console.ReadLine();
        }
    }
}
