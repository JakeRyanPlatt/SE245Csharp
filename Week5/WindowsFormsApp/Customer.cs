using System;
namespace WindowsFormsApp
{
    public class Customer : PersonV2
    {
        private DateTime customerSince = DateTime.Now;
        private double totalPurchases = 0.0;
        private bool discountMember = false;
        private int rewardsEarned = 0;
        public Customer() : base() { }
        public Customer(string firstName, string lastName, string email, string state, string zip,
                        string cellPhone, string instagramURL,
                        DateTime customerSince, double totalPurchases, bool discountMember, int rewardsEarned)
            : base(firstName, lastName, email, state, zip, cellPhone, instagramURL)
        {
            try { CustomerSince = customerSince; }
            catch (Exception ex) { Feedback += "Customer Since: " + ex.Message + Environment.NewLine; }
            try { TotalPurchases = totalPurchases; }
            catch (Exception ex) { Feedback += "Total Purchases: " + ex.Message + Environment.NewLine; }
            DiscountMember = discountMember;
            try { RewardsEarned = rewardsEarned; }
            catch (Exception ex) { Feedback += "Rewards Earned: " + ex.Message + Environment.NewLine; }
        }
        public DateTime CustomerSince
        {
            get { return customerSince; }
            set
            {
                if (WindowsFormsApp.Validate.IsAFutureDate(value))
                    throw new Exception("Customer Since cannot be a future date.");
                customerSince = value;
            }
        }
        public double TotalPurchases
        {
            get { return totalPurchases; }
            set
            {
                if (!WindowsFormsApp.Validate.IsMinimumAmount(value, 0.0))
                    throw new Exception("Total Purchases cannot be negative.");
                totalPurchases = value;
            }
        }
        public bool DiscountMember
        {
            get { return discountMember; }
            set { discountMember = value; }
        }
        public int RewardsEarned
        {
            get { return rewardsEarned; }
            set
            {
                if (!WindowsFormsApp.Validate.IsMinimumAmount(value, 0))
                    throw new Exception("Rewards Earned cannot be negative.");
                rewardsEarned = value;
            }
        }
        public int YearsAsCustomer
        {
            get { return (int)((DateTime.Now - customerSince).TotalDays / 365.25); }
        }
        public string GetCustomerSummary()
        {
            return
                "Name:           " + FirstName + " " + LastName + Environment.NewLine +
                "Email:          " + Email + Environment.NewLine +
                "State / ZIP:    " + StateCode + "  " + Zip + Environment.NewLine +
                "Cell Phone:     " + CellPhone + Environment.NewLine +
                "Instagram:      " + InstagramURL + Environment.NewLine +
                "Customer Since: " + customerSince.ToString("MM/dd/yyyy") + " (" + YearsAsCustomer + " yrs)" + Environment.NewLine +
                "Total Purchases:" + totalPurchases.ToString("C") + Environment.NewLine +
                "Discount Member:" + (discountMember ? "Yes" : "No") + Environment.NewLine +
                "Rewards Earned: " + rewardsEarned + " pts";
        }
    }
}