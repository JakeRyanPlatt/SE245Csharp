using System;
namespace WindowsFormsApp
{
    public class Person
    {
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string stateCode = "";
        private string zip = "";
        private string cellPhone = "";
        private string InstagraURL = "";
        private string feedback = "";
        public Person()
        {
            firstName = "";
            lastName = "";
            email = "";
            stateCode = "";
            zip = "";
            cellPhone = "";
            InstagraURL = "";
            feedback = "";
        }
        public Person(string firstName, string lastName, string email, string state, string zip)
        {
            try { FirstName = firstName; }
            catch (Exception ex) { feedback += "First Name: " + ex.Message + Environment.NewLine; }
            try { LastName = lastName; }
            catch (Exception ex) { feedback += "Last Name: " + ex.Message + Environment.NewLine; }
            Email = email;
            StateCode = state;
            Zip = zip;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (WindowsFormsApp.Validate.IsFilledIn(value))
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
                if (WindowsFormsApp.Validate.IsFilledIn(value))
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
        public string StateCode
        {
            get { return stateCode; }
            set { stateCode = value.Trim().ToUpper(); }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value.Trim(); }
        }
        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }
        public void ClearFeedback()
        {
            feedback = "";
        }
    }
}