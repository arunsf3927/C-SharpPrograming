using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class UserDetailsClass
    {
        private static int s_userId =1001;
        public string UserId{get;}
        public string UserName{get;set;}
        public int Age{get;set;}
        public  string City {get;set;}
        public long PhoneNumber{get;set;}
        public double Balance {get;set;}
        public UserDetailsClass(string userName,int age,string city,long phoneNumber,double balance)
        {
           s_userId++;
           UserId="UID"+s_userId;
           UserName=userName;
           Age=age;
           City=city;
           PhoneNumber=phoneNumber;
           Balance=balance;
        }
        public UserDetailsClass (string data)
        {
            string [] values = data.Split(',');
            s_userId= int.Parse(values[0].Remove(0,5));
            UserId=values[0];
            UserName=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            PhoneNumber=long.Parse(values[4]);
            Balance=double.Parse(values[5]);
        }
    }
}