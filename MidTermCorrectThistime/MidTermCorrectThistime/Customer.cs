using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidTerm;

namespace MidTermCorrectThistime
{
    class Customer : PersonV2
    {
        private DateTime customerSince;
        private double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;

        public Customer()
        {
            customerSince = DateTime.MinValue;
            totalPurchases = 0;
            discountMember = false;
            rewardsEarned = 0;
        }



        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }
            set
            {
                customerSince = value;
                feedbackClass += "\n" + value;
            }

        }

        public double TotalPurchases
        {
            get
            {
                return totalPurchases;
            }
            set
            {
                totalPurchases = value;
                feedbackClass += "\n" + value;
            }
        }
        public bool DiscountMember
        {
            get
            {
                return discountMember;
            }
            set
            {
                discountMember = value;
                feedbackClass += "\n" + value;
            }
        }
        public int RewardsEarned
        {
            get
            {
                return rewardsEarned;
            }
            set
            {
                rewardsEarned = value;
                feedbackClass += "\n" + value;
            }
        }
    }
}
