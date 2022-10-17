using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance;
 public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetails
    {
        private static int s_adharId=100;
        public string AdharId{get;}
        public  string Name{get;set;} 
        public  string FatherName{get;set;}
        public  Gender Gender{get;set;}  
        public long PhoneNumber{get;set;}
        public PersonalDetails(string name,string fatherName,Gender gender,long phoneNumber)
        {
            s_adharId++;
            AdharId="AID"+s_adharId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;  
        }
        public PersonalDetails( string adharId,string name,string fatherName,Gender gender,long phoneNumber)
        {
            AdharId=adharId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;  
        }    
        public void ShowDetails()
            {
                System.Console.WriteLine(AdharId);
                System.Console.WriteLine($"Name is:{Name}\nFather's Name is:{FatherName}\nGender:{Gender}\nPhoneNumber:{PhoneNumber}");  
            }
        }
    
