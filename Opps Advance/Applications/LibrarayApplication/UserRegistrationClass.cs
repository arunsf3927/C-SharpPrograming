using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarayApplication;

    public enum Gender{Default,male,female}
    public enum Department{Default,ECE,EEE,CSC}

    public class UserRegistrationClass
    {
        private static int s_registerationNumber=1001;//properties
        public static string RegisterationNumber{get;set;}
        public  static string  UserName{get;set;}
        public Gender Gender {get;set;}
        public Department Department{get;set;}
        public long  MobileNumber{get;set;}
        public string MailId{get;set;}
        public UserRegistrationClass(string username,Gender gender,Department department,long mobilenumber,string mailId)//Constructor
        {
            s_registerationNumber++;
            RegisterationNumber = "SF"+s_registerationNumber;
            UserName = username;
            Gender = gender;
            Department = department;
            MobileNumber = mobilenumber;
            MailId =  mailId;

        }
        
            
    }
    
