using System;

namespace WindowsFormsApp1
{
    public class Person
    {
        private string fName;
        private string lName;
        private string email;
        private int age;

        public string Feedback { get; protected set; }

        public string FName
        {
            get { return fName; }
            set
            {
                if (Validate.IsFilledIn(value))
                    fName = value.Trim();
                else
                    Feedback += "\nERROR: First Name is required.";
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (Validate.IsFilledIn(value))
                    lName = value.Trim();
                else
                    Feedback += "\nERROR: Last Name is required.";
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (Validate.IsValidEmail(value))
                    email = value.Trim();
                else
                    Feedback += "\nERROR: Invalid email address.";
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (Validate.IsInRange(value, 0, 120))
                    age = value;
                else
                    Feedback += "\nERROR: Age must be between 0 and 120.";
            }
        }

        public Person()
        {
            Feedback = "";
        }

        public Person(string fName, string lName, string email, int age) : this()
        {
            FName = fName;
            LName = lName;
            Email = email;
            Age = age;
        }

        public void ClearFeedback() => Feedback = "";

        public override string ToString() =>
            $"{FName} {LName} | Email: {Email} | Age: {Age}";
    }
}