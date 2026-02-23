using System;
using System.Text.RegularExpressions;

namespace  WindowsFormsAppLab7
{
    public static class Validate
    {
        public static bool IsFilledIn(string value) =>
            !string.IsNullOrWhiteSpace(value);

        public static bool IsValidEmail(string value) =>
            IsFilledIn(value) && Regex.IsMatch(value.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public static bool IsValidPhone(string value) =>
            IsFilledIn(value) && Regex.IsMatch(value.Trim(),
                @"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$");

        public static bool IsInRange(int value, int min, int max) =>
            value >= min && value <= max;

        public static bool IsPositiveDouble(double value) =>
            value >= 0;
    }
}