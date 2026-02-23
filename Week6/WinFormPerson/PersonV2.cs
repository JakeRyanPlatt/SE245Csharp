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
            {
                cellPhone = value.Trim();
            }
            else
            {
                Feedback += "\nERROR: Invalid cell phone number.";
            }
        }
    }

    public string InstagramURL
    {
        get { return instagramUrl; }
        set
        {
            if (Validate.IsFilledIn(value))
            {
                instagramUrl = value.Trim();
            }
            else
            {
                Feedback += "\nERROR: Instagram URL is required.";
            }
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
}