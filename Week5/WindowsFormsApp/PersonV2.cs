using System;
using System.Text.RegularExpressions;
namespace WindowsFormsApp
{
    public class PersonV2 : Person
    {
        private string cellPhone = "";
        private string instagramURL = "";
        public PersonV2() : base() { }
        public PersonV2(string firstName, string lastName, string email, string state, string zip, string cellPhone, string instagramURL)
            : base(firstName, lastName, email, state, zip)
        {
            try { CellPhone = cellPhone; }
            catch (Exception ex) { Feedback += "Cell Phone: " + ex.Message + Environment.NewLine; }
            try { InstagramURL = instagramURL; }
            catch (Exception ex) { Feedback += "Instagram URL: " + ex.Message + Environment.NewLine; }
        }
        public string CellPhone
        {
            get { return cellPhone; }
            set
            {
                string digits = Regex.Replace(value, @"[\s\-\(\)\.]", "");
                if (!WindowsFormsApp.Validate.IsFilledIn(digits))
                    throw new Exception("Cell phone is required.");
                if (digits.Length != 10 || !long.TryParse(digits, out _))
                    throw new Exception("Cell phone must be 10 digits (ex: 4015551234).");
                cellPhone = digits;
            }
        }
        public string InstagramURL
        {
            get { return instagramURL; }
            set
            {
                if (!WindowsFormsApp.Validate.IsFilledIn(value))
                {
                    instagramURL = "";
                    return;
                }
                string lower = value.Trim().ToLower();
                if (!lower.StartsWith("https://www.instagram.com/"))
                    throw new Exception("Instagram URL must start with https://www.instagram.com/");
                instagramURL = value.Trim();
            }
        }
    }
}