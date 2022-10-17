using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace FoodDeliveryApplication
{
    
    public enum Gender {Default,male,female}
    public class PersonalDetailsClass
    {
        public string  Name{get;set;}
        public string FatherName{get;set;}
        public Gender Gender{get;set;}
        public long MobileNumber{get;set;}
        public DateTime DOB{get;set;}
        public string MailId{get;set;}
        public string Location{get;set;}
        public PersonalDetailsClass(string name,string fatherName,Gender gender,long mobileNummber,DateTime dob,string mailId,string location)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNummber;
            DOB=dob;
            MailId=mailId;
            Location=location;   
        }
       public PersonalDetailsClass()
       {

       }
    }
}