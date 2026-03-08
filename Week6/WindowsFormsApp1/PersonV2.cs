
using System;
using System.Data.SqlClient;
using System.Runtime.ExceptionServices;

namespace WindowsFormsApp1
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

        public override string ToString() =>
            base.ToString() + $" | Phone: {CellPhone} | Instagram: {InstagramURL}";
    }

            // Connect to DB AND inserts a record (AddARecord function)

         public string AddARecord()
        {
            string strResult = "";
            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = @"Server=sql.neit.edu\studentssqlserver,4500;Database=dev_202620_jrplatt;User Id="dev_202620_jrplatt; Password = 00802; ";"


    string strSQL = "INSERT INTO Contacts (fname, lname, AuthorLast, Email, Pages, DatePublished, DateRentalExpires, BookmarkPage) VALUES (@Title, @AuthorFirstName, @AuthorLastName, @Email, @Pages, @DatePublished ,@DateRentalExpires,@BookmarkPage)";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@First Name", First);
            comm.Parameters.AddWithValue("@Last Name", Last);
            comm.Parameters.AddWithValue("@AuthorLastName", AuthorLastName);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Pages", Pages);
            comm.Parameters.AddWithValue("@DatePublished", DatePublished);
            comm.Parameters.AddWithValue("@DateRentalExpires", DateRentalExpires);
            comm.Parameters.AddWithValue("@BookmarkPage", BookmarkPage);

            // attempt to connect and execute the command

            try
            {
                Conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} record(s).";
                Conn.Close();
            }
            catch (Exception ex)
            {
                strResult = "ERROR: " + ex.Message;
            }
            finally
            {

            }
            return strResult;
        }