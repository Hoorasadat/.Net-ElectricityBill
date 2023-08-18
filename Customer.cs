using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Customer
    {
        int accountNo;
        string firstName;
        string lastName;

        decimal adminFee = 12;
        decimal kwhCost = 0.07m;

        private decimal powerUsage;
        public decimal PowerUsage
        {
            get { return powerUsage; }
            set
            {
                if (value > 0)
                {
                    powerUsage = value;
                }
            }
        }

        private decimal billAmount;
        public decimal BillAmount
        {
            get { return billAmount; }
        }

        // constructor method
        public Customer(string fstNm, string lstNm, decimal pwrUsg)
        {
            Guid uniqueId = Guid.NewGuid();
            int hashedValue = uniqueId.GetHashCode();

            accountNo = hashedValue;
            firstName = fstNm;
            lastName = lstNm;
            powerUsage = pwrUsg;
        }

        // calculate cost method
        public decimal CalculateCharge()
        {
            decimal powerCost = 0;

            powerCost = kwhCost * powerUsage + adminFee;

            return powerCost;
        }

        public override string ToString()
        {
            string billString = CalculateCharge().ToString("C");
            return $"{firstName} {lastName} with account no. {accountNo} has a bill of {billString}";
        }


    }
}
