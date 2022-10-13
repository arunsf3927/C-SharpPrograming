using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountDetails
{
     public enum AccountType{Default,Fd,SD}
      public enum Gender{Default,Male,Feamle,transgender}
    public class AccountDetails
    {
        private static int s_accountNumber=3000;
        public string AccountNumber { get; }
        public string Name { get; set; } //Autoproperty declaration
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
       public AccountType AccountType{get;set;}
       public double Balance {get;set;}

       //parameterised constructor
        public AccountDetails(string name,string fathername,Gender gender,DateTime dob, AccountType accounttype)
        {
            s_accountNumber++;
            AccountNumber="SF"+s_accountNumber;
            
            Name=name;
            FatherName=fathername;
            Gender=gender;
            DOB=dob;
            AccountType=accounttype;
        }
        public void Deposite()
        {
            System.Console.WriteLine("Enter the amount");
            double deposite=double.Parse(Console.ReadLine());
            Balance=Balance+deposite;
            System.Console.WriteLine("Your Balance :"+Balance);
            System.Console.WriteLine("Enter the amount");
        }
         public void Withdraw()
            {
                System.Console.WriteLine("Enter the amount to withdraw");
            double withdraw=double.Parse(Console.ReadLine());
            
            }
            
        }
      
    }
