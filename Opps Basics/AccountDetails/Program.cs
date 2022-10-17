using System;
using System.Collections.Generic;
namespace AccountDetails
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<AccountDetails> AccountList = new List<AccountDetails>();
            System.Console.WriteLine("Enter If you want to create an account");
            string willing =Console.ReadLine().ToLower(); 
            while(willing=="yes")
            {
             System.Console.WriteLine("Enter the name :");
             string name = Console.ReadLine();

              System.Console.WriteLine("Enter the Fathername :");
             string fathername = Console.ReadLine();

              System.Console.WriteLine("Enter the Gender:");
             Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

              System.Console.WriteLine("Enter the Dob :");
             DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd//MM//yyyy",null);

              System.Console.WriteLine("Enter the Account Type:");
             AccountType accountype = Enum.Parse<AccountType>(Console.ReadLine(),true);

             AccountDetails Account= new AccountDetails(name,fathername,gender,dob,accountype);
             AccountList.Add(Account);
             Account.Deposite();
             Account.Withdraw();
             System.Console.WriteLine("Your name is :"+Account.Name+"\n Your Fathername :"+Account.FatherName+"\n gender :"+Account.Gender+"\"\n Your DOB"+Account.DOB.ToString("dd//MM//yyyy")+"\n Account Type :"+Account.AccountType+"\n Balance is :"+Account.Balance+"\n Account number :"+Account.AccountNumber+"\n Balance is :"+Account.Balance);
             
            }
               System.Console.WriteLine("Enter If you want to create an account");
             willing =Console.ReadLine().ToLower(); /*~AccountDetails {}*/
             
        
        }
       

    }
}
