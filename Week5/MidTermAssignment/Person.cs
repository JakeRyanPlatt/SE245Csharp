// Jake Platt
// SE245
// 2/4/2026
// This program demonstrates a Person class with property-based validation
using System;
using System.Linq;
using System.Text.RegularExpressions;



namespace MidTermAssignment
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
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Phone number is required.");

                // Remove common formatting characters
                var digitsOnly = Regex.Replace(value, @"[^\d]", "");

                if (digitsOnly.Length ==10)
                {
                    phone = value;
                }
                else
                {
                    throw new Exception("Phone number must contain at least 10 digits.");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (Validate.IsValidEmail(value) && value.Contains("."))
                    email = value;
                else
                    throw new Exception("Email must be in a valid format and contain a '.'");
            }
        }
    }
}
