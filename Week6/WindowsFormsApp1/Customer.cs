using System;


namespace WindowsFormsApp1
{
    public class Customer : PersonV2
    {
        private double totalPurchases;
        private int rewardsEarned;

        public DateTime CustomerSince { get; set; }

        public double TotalPurchases
        {
            get { return totalPurchases; }
            set
            {
                if (Validate.IsPositiveDouble(value))
                    totalPurchases = value;
                else
                    Feedback += "\nERROR: Total Purchases cannot be negative.";
            }
        }

        public bool DiscountMember { get; set; }

        public int RewardsEarned
        {
            get { return rewardsEarned; }
            set
            {
                if (value >= 0)
                    rewardsEarned = value;
                else
                    Feedback += "\nERROR: Rewards Earned cannot be negative.";
            }
        }

        public Customer() : base()
        {
            CustomerSince = DateTime.Now;
        }

        public Customer(string fName, string lName, string email, int age,
                        string cellPhone, string instagramUrl,
                        DateTime customerSince, double totalPurchases,
                        bool discountMember, int rewardsEarned)
            : base(fName, lName, email, age, cellPhone, instagramUrl)
        {
            CustomerSince = customerSince;
            TotalPurchases = totalPurchases;
            DiscountMember = discountMember;
            RewardsEarned = rewardsEarned;
        }

        public override string ToString() =>
            base.ToString() +
            $" | Customer Since: {CustomerSince:d} | Purchases: {TotalPurchases:C}" +
            $" | Discount Member: {DiscountMember} | Rewards: {RewardsEarned}";
    }
}