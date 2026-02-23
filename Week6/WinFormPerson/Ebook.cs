using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// may need to add BasicTools and Validation libraries from week 4
// using Week4_Class1;
// using Validate.cs;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Week6_Sample_DataValidation
{
    class Ebook : Book
    {
       private DateTime dateRentalExpires;
       private int bookmarkPage;

       public DateTime DateRentalExpires
    {
           get { return dateRentalExpires; } 
           set { dateRentalExpires = value; }
    }
        if (Validate.IsAFutureDate(value))
        {
            dateRentalExpires = value;
        }
        else
        {
            feedback += "The date must be in the future. Please try again.\n";
        }
        public interface BookmarkPage
        {
            get { return bookmarkPage; }
            set { bookmarkPage = value; }
        }
         if (Validate.IsPositiveInteger(value))
        {
            bookmarkPage = value;
        }
        else
        {
            feedback += "The page number must be a positive integer. Please try again.\n";
        }
    }
}
    public int BookmarkPage
        {
        get { return bookmarkPage; }
        set { bookmarkPage = value; }
        }
         if (validationLibrary.IsMinimumAmount(value, 1) == true && value <= Pages)
        {
            bookmarkPage = value;
        }
        else
        {
            feedback += "The page number must be a positive integer. Please try again.\n";
        }
         // Connect to DB AND inserts a record (AddARecord function)

         public string AddARecord2()
{
    string strResult = "";
    SqlConnection Conn = new SqlConnection();

    Conn.ConnectionString = @"Server=sql.neit.edu\studentssqlserver,4500;Database=dev_202620_jrplatt;User Id="dev_202620_jrplatt;Password=00802;";"
    
    string strSQL = "INSERT INTO EBooks (Tile, AuthorFirst, AuthorLast, Email, Pages, DatePublished, DateRentalExpires, BookmarkPage) VALUES (@Title, @AuthorFirstName, @AuthorLastName, @Email, @Pages, @DatePublished ,@DateRentalExpires,@BookmarkPage)";
    SqlCommand comm = new SqlCommand();
    comm.CommandText = strSQL;
    comm.Connection = Conn;

    comm.Parameters.AddWithValue("@Title", Title);
    comm.Parameters.AddWithValue("@AuthorFirstName", AuthorFirstName);
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
// Default Constructor; calls the parents constructor    
public Ebook(): base() 
        {
            BookmarkPage = 1;
            dateRentalExpires =  Date.Time.Now.AddDays(14); // default rental period of 14 days
        }
    }
}


