using System;
using System.Data.SqlClient;

namespace WindowsFormsAppLab7
{
    public class PersonV2 : Person
    {
        private string cellPhone;
        private string instagramUrl;

        public string CellPhone
        {
            get { return cellPhone; }
            set
            {
                if (Validate.IsValidPhone(value))
                    cellPhone = value.Trim();
                else
                    Feedback += "\nERROR: Invalid cell phone number.";
            }
        }

        public string InstagramURL
        {
            get { return instagramUrl; }
            set
            {
                if (Validate.IsFilledIn(value))
                    instagramUrl = value.Trim();
                else
                    Feedback += "\nERROR: Instagram URL is required.";
            }
        }

        public PersonV2() : base() { }

        public PersonV2(string fName, string lName, string email, int age,
                        string cellPhone, string instagramUrl)
            : base(fName, lName, email, age)
        {
            CellPhone = cellPhone;
            InstagramURL = instagramUrl;
        }

        public string AddToDatabase()
        {
            string result = "";

            if (!string.IsNullOrEmpty(Feedback))
                return "ERROR: Please fix validation errors before saving.\n" + Feedback;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=sql.neit.edu\studentssqlserver,4500;" +
                                     "Database=dev_202620_jrplatt;" +
                                     "User Id=dev_202620_jrplatt;" +
                                     "Password=008024861;" +
                                     "TrustServerCertificate=True;";

            string sql = "INSERT INTO PersonV2 (FName, LName, Email, Age, CellPhone, InstagramURL) " +
                         "VALUES (@FName, @LName, @Email, @Age, @CellPhone, @InstagramURL)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FName", FName);
            cmd.Parameters.AddWithValue("@LName", LName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@CellPhone", CellPhone);
            cmd.Parameters.AddWithValue("@InstagramURL", InstagramURL);

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                result = $"SUCCESS: {rows} record inserted.";
                conn.Close();
            }
            catch (Exception ex)
            {
                result = "DB ERROR: " + ex.Message;
            }

            return result;
        }

        public override string ToString() =>
            base.ToString() + $" | Phone: {CellPhone} | Instagram: {InstagramURL}";

    }
}