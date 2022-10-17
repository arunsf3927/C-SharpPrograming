using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public class CustemerRgistrationClass:PersonalDetailsClass
    {
        private static int s_custemorId=1001;
        public  string CustemerId{get;set;}
        public int WalletBalance{get;set;}
        public CustemerRgistrationClass(string name,string fathername,Gender gender,long mobileNumber,DateTime dob,string mailId,string location,int walletbalance):base(name,fathername,gender,mobileNumber,dob,mailId,location)
        {
            s_custemorId++;
            CustemerId="CID"+s_custemorId;
            WalletBalance=walletbalance;
        }
        public CustemerRgistrationClass (string data)
        {
            string[] values = data.Split(',');
            s_custemorId=int.Parse(values[0].Remove(0,3));
            CustemerId=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            MobileNumber=long.Parse(values[4]);
            DOB=DateTime.Parse(values[5]);
            MailId=values[6];
            Location=values[7];
            WalletBalance=int.Parse(values[8]);
        }
  
            
    }
        }
    
