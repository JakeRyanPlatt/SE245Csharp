using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppLab7
{
    public class PersonV2 : Person
    {
        private string cellPhone;
        private string instagramUrl;

        // Connection string (change password here only) 
        private static readonly string ConnString =
            @"Server=sql.neit.edu\studentssqlserver,4500;" +
             "Database=dev_202620_jrplatt;" +
             "User Id=dev_202620_jrplatt;" +
             "Password= ;" +
             "TrustServerCertificate=True;";

        //  Properties 
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

        //  Constructors 
        public PersonV2() : base() { }

        public PersonV2(string fName, string lName, string email, int age,
                        string cellPhone, string instagramUrl)
            : base(fName, lName, email, age)
        {
            CellPhone = cellPhone;
            InstagramURL = instagramUrl;
        }

        //  INSERT
        public string AddToDatabase()
        {
            if (!string.IsNullOrEmpty(Feedback))
                return "ERROR: Please fix validation errors before saving.\n" + Feedback;

            string sql = "INSERT INTO PersonV2 (FName, LName, Email, Age, CellPhone, InstagramURL) " +
                         "VALUES (@FName, @LName, @Email, @Age, @CellPhone, @InstagramURL)";

            using (SqlConnection conn = new SqlConnection(ConnString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
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
                    return $"SUCCESS: {rows} record inserted.";
                }
                catch (Exception ex)
                {
                    return "DB ERROR: " + ex.Message;
                }
            }
        }

        //  SEARCH: All records 
        public static DataTable GetAllPeople()
        {
            return RunQuery("SELECT * FROM PersonV2 ORDER BY LName, FName", null);
        }

        //  SEARCH: By Name (partial match on first or last) 
        public static DataTable SearchByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;

            string sql = "SELECT * FROM PersonV2 " +
                         "WHERE FName LIKE @Name OR LName LIKE @Name " +
                         "ORDER BY LName, FName";

            return RunQuery(sql, new SqlParameter[] {
                new SqlParameter("@Name", "%" + name.Trim() + "%")
            });
        }
        //  SEARCH: By PersonID 
        public static DataTable SearchByID(int personId)
        {
            return RunQuery(
                "SELECT * FROM PersonV2 WHERE PersonID = @PersonID",
                new SqlParameter[] { new SqlParameter("@PersonID", personId) }
            );
        }

        //  SEARCH: By Email (partial match) 
        public static DataTable SearchByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return null;

            return RunQuery(
                "SELECT * FROM PersonV2 WHERE Email LIKE @Email ORDER BY Email",
                new SqlParameter[] { new SqlParameter("@Email", "%" + email.Trim() + "%") }
            );
        }

        //  UPDATE 
        public static string UpdatePerson(int personId, string fName, string lName,
                                          string email, int age,
                                          string cellPhone, string instagramUrl)
        {
            string sql = "UPDATE PersonV2 SET " +
                         "FName=@FName, LName=@LName, Email=@Email, " +
                         "Age=@Age, CellPhone=@CellPhone, InstagramURL=@InstagramURL " +
                         "WHERE PersonID=@PersonID";

            using (SqlConnection conn = new SqlConnection(ConnString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", personId);
                cmd.Parameters.AddWithValue("@FName", fName);
                cmd.Parameters.AddWithValue("@LName", lName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@CellPhone", cellPhone);
                cmd.Parameters.AddWithValue("@InstagramURL", instagramUrl);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0
                        ? $"SUCCESS: Record {personId} updated."
                        : $"WARNING: No record found with PersonID {personId}.";
                }
                catch (Exception ex) { return "DB ERROR: " + ex.Message; }
            }
        }

        //  DELETE 
        public static string DeletePerson(int personId)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM PersonV2 WHERE PersonID=@PersonID", conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", personId);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0
                        ? $"SUCCESS: Record {personId} deleted."
                        : $"WARNING: No record found with PersonID {personId}.";
                }
                catch (Exception ex) { return "DB ERROR: " + ex.Message; }
            }
        }

        //  Private helper: run any SELECT, return DataTable
        private static DataTable RunQuery(string sql, SqlParameter[] parms)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parms != null)
                    cmd.Parameters.AddRange(parms);
                try
                {
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Error");
                    dt.Rows.Add("DB ERROR: " + ex.Message);
                }
            }
            return dt;
        }

        // ToString 
        public override string ToString() =>
            base.ToString() + $" | Phone: {CellPhone} | Instagram: {InstagramURL}";
    }
}
