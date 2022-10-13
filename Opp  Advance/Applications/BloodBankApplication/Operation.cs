using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankApplication;

    public class Operation
    {
        static UserRegistrationClass CurrentUser=null;
        static List<UserRegistrationClass> UserList=new List<UserRegistrationClass>();
           static DonationClass CurrentDonation=null;
           static List<DonationClass> DonationList = new List<DonationClass>();
           public static void MainMenu()
           {
            string choice="yes";
           do
           {
            System.Console.WriteLine("Enter your Option 1.UserRegistration 2.UserLogin 3.FetchDonarDetails 4.Exit ");
            int Option =int.Parse(Console.ReadLine());
            switch(Option)
            {
                case 1:
                {
                System.Console.WriteLine("UserRegistration");
                UserRegistration();
                break;
                }
            
            }
           }
           while(choice=="yes");
           }

           //UserRegistration
           public  static void UserRegistration()
           {
            System.Console.WriteLine("Enter Donar Name");
            string Name=Console.ReadLine();

            System.Console.WriteLine("Enter the age");
            int Age =int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the User Mobile Number");
            long MobileNumber=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the User Blood Group");
            BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine());
            UserRegistrationClass registration=new UserRegistrationClass(donarId,mobileNumber,bloodGroup,age,lastDonation);
            UserList.Add(registration);
            }
           public static void  UserLogin()
           {
            System.Console.WriteLine("Enter the DonarId");
            int DonarId=int.Parse(Console.ReadLine());


           }
           public static void FetchDonardetails()
           {

           }
           }
           
    

    
