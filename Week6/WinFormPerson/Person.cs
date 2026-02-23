using System;

namespace WinFormPerson
{

    //Base Person class with validation and feedback.
    // Demonstrates private fields, public properties with get/set accessors,
    // Data validation, and constructor chaining.

    public class Person
    {
        // ── Private backing fields ──────────────────────────────────────────
        private string fName;
        private string lName;
        private string email;
        private int age;

        // ── Feedback property (read externally, written only by class) ──────
        public string Feedback { get; protected set; }

        // ── Properties (Accessors = Get, Mutators = Set) ────────────────────

        /// <summary>First Name – must be filled in.</summary>
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

        /// <summary>Last Name – must be filled in.</summary>
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

        /// <summary>Email – must pass basic format check.</summary>
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

        /// <summary>Age – must be 0–120.</summary>
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                    age = value;
                else
                    Feedback += "\nERROR: Age must be between 0 and 120.";
            }
        }

        // ── Constructors ────────────────────────────────────────────────────

        /// <summary>Default constructor – initialises Feedback to empty string.</summary>
        public Person()
        {
            Feedback = "";
        }

        /// <summary>Parameterised constructor – chains to default, then sets properties
        /// so validation (and Feedback) runs automatically.</summary>
        public Person(string fName, string lName, string email, int age) : this()
        {
            FName = fName;
            LName = lName;
            Email = email;
            Age = age;
        }

        // ── Helper ──────────────────────────────────────────────────────────

        public void ClearFeedback() => Feedback = "";

        public override string ToString()
        {
            return $"{FName} {LName} | Email: {Email} | Age: {Age}";
        }
    }
}