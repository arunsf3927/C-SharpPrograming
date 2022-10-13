using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApplication;
public enum Gender{Default,Male,female,Others}

    public class BeneficiaryClass
    {
        private static int s_registration=1000;
        public string RegisterationNumber{get;set;} 
        public string Name{get;set;}
        public Gender Gender {get;set;}
        public long MobileNumber{get;set;}
        public string City{get;set;}
        public int Age{get;set;}
        public BeneficiaryClass(string name,Gender gender,long mobileNumber,string city,int age)
        {
            s_registration++;
            RegisterationNumber="BID"+s_registration;
            Name=name;
            Gender=gender;   
            MobileNumber=mobileNumber;
            City=city;
            Age=age;          
        }
        public BeneficiaryClass (string data)
        {
            string[] values = data.Split(',');
            s_registration=int.Parse(values[0].Remove(0,3));
            RegisterationNumber=values[0];
            Name=values[1];
            Gender=Enum.Parse<Gender>(values[2]);
            MobileNumber=long.Parse(values[3]);
            City=values[4];
            Age=int.Parse(values[5]);
        
        }
    }
