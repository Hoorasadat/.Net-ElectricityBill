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

        private decimal powerUsage = 0;
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

        // 1st constructor method
        public Customer(int accNo, string fstNm, string lstNm, decimal pwrUsg)
        {
            accountNo = accNo;
            firstName = fstNm;
            lastName = lstNm;
            powerUsage = pwrUsg;
        }

        // 2nd constructor method
        public Customer(string fstNm, string lstNm, decimal pwrUsg)
        {
            Guid uniqueId = Guid.NewGuid();
            int hashedValue = Math.Abs(uniqueId.GetHashCode());

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

            billAmount = powerCost;

            return powerCost;
        }

        public override string ToString()
        {
            string billString = CalculateCharge().ToString("C");
            return $"{firstName} {lastName} with account no. {accountNo} has a bill of {billString}";
        }

        public string CreateCustomer()
        {
            string billString = CalculateCharge().ToString("C");
            return $"First Name: {firstName}, Last Name: {lastName}, Account #: {accountNo}, Bill: ${billString}";
        }
    }
}
