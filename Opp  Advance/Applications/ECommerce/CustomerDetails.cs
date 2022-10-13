using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class CustomerDetails
    {
        private static int _customerID = 1000;

        public string CustomerID { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public long Mobile { get; set; }

        public double WalletBalance { get; set; }

        public string Mail { get; set; }

        public CustomerDetails(string name, string city, long mobile, double walletBalance, string mail)
        {
            _customerID++;
            CustomerID = $"CID{_customerID}";
            Name = name;
            City = city;
            Mobile = mobile;
            WalletBalance = walletBalance;
            Mail = mail;
        }

        public void WalletRecharge(double amount)
        {
            if (0 < amount)
            {
                WalletBalance += amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }
    }
}