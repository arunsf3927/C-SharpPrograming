using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    public class UserDetailsClass:PersonalDetailsClass,IWallet
    {
        /// <summary>
        ///  used for assiagn  a value for User Id
        /// </summary>
        public static int s_userId=1001;
        public string UserId { get; set; }
        /// <summary>
        /// Used For Assigning a Wallet
        /// </summary>
        /// <value></value>
        public double WalletBalance{get;set;}
        public UserDetailsClass(string name,int age,long phoneNumber,string userId,double walletBalance):base(name,age,phoneNumber)
        {
            s_userId++;
            UserId="UID"+s_userId;
            WalletBalance=walletBalance;
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;
        }
        public static void WalletRecharge()
        {
            
        }
       
      
    }
}