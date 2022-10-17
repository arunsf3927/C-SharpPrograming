using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    public interface IWallet
    {
        public  double WalletBalance{get;set;}
        void WalletRecharge()
        {
          System.Console.WriteLine("Enter the amount");
            double amount = double.Parse(Console.ReadLine());
            WalletBalance+=amount;
        }
    }
}