using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankApplication;
public enum BloodGroup{Default,A_Positive,B_Positive,O_Positive,AB_Positive}

    public class UserRegistrationClass
    {
            public static int s_DonarId=1000;
            public string DonarId{get;set;}
            public long MobileNumber{get;set;}
            public BloodGroup BloodGroup{get;set;}
            public int Age{get;set;}
            public DateTime LastDonation{get;set;}
            public UserRegistrationClass(string donarId,long mobileNumber,BloodGroup bloodGroup,int age,DateTime lastDonation)
            {
                s_DonarId++;
                DonarId="D"+s_DonarId;
                MobileNumber=mobileNumber;
                BloodGroup=bloodGroup;
                Age=age;
                LastDonation=lastDonation;
                
            }
    
}