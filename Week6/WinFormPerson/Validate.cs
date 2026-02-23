using System;
using System.Linq;

namespace WinFormPerson
{
    public static class Validate
    {
        public static bool GotBadWords(string temp)
        {
            return temp.Contains("Badword");
        }

        public static bool IsFilledIn(string temp)
        {
            return !string.IsNullOrWhiteSpace(temp);
        }

        public static bool IsMinLength(string temp, int minLen)
        {
            return temp != null && temp.Length >= minLen;
        }

        public static bool IsAFutureDate(DateTime temp)
        {
            return temp > DateTime.Now;
        }

        public static bool IsValidEmail(string temp)
        {
            if (temp == null || temp.Length < 8) return false;

            int atLocation = temp.IndexOf("@");
            int periodLocation = temp.LastIndexOf(".");

            if (atLocation < 2) return false;
            if (periodLocation + 2 > temp.Length) return false;
            if (periodLocation < atLocation) return false;

            return true;
        }

        public static bool IsMinimumAmount(int temp, int min)
        {
            return temp >= min;
        }

        public static bool IsMinimumAmount(double temp, double min)
        {
            return temp >= min;
        }

        public static bool IsValidPhone(string value)
        {
            if (!IsFilledIn(value)) return false;
            string digits = new string(value.Where(char.IsDigit).ToArray());
            return digits.Length == 10;
        }

        public static bool IsValidUrl(string value)
        {
            if (!IsFilledIn(value)) return false;
            return value.StartsWith("http://") || value.StartsWith("https://") || value.StartsWith("www.");
        }
    }
}