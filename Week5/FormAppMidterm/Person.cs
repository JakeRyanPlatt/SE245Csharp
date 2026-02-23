using System;

namespace FormAppMidterm
{
    public class Person
    {
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string state = "";
        private string zip = "";
        private string feedback = "";

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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }
    }
}