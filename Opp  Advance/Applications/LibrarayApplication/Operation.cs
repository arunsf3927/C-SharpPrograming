using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarayApplication
{
    public class Operation
    {
        //creation of null for current User
      static  UserRegistrationClass currentUser   = null;
      //List Creation for UserRegistration
      static List<UserRegistrationClass> UserRegistrationList = new List<UserRegistrationClass>();
      // creation of List for Bookdetails
      static List<BookDetailsClass> BookDetailsList = new List<BookDetailsClass>();
      public static void MainMenu()
      {
        string choice="yes";
        do
        {
            System.Console.WriteLine("enter the Option for the MainMenu \n1.UserRegistration \n2.UserLogin \n3.exit");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                {
                    System.Console.WriteLine("Enter the UserRegistration");
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Enter the UserLogin");
                    UserLogin();
                    break;
                }
                case 3:
                {
                    break;
                }
            }
        
            }
        while(choice=="yes");
      }
        public static void UserRegistration()
        {
        System.Console.WriteLine("Enter the UserName");    
        string userName=Console.ReadLine();

        System.Console.WriteLine("Enter the User gender in this formate Default,male,female");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter the UserDepartment in this formate Default,ECE,EEE,CSC");
        Department department = Enum.Parse<Department>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter the User MobileNumber");
        long mobilenumber = long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the MailId");
        string mailId = Console.ReadLine();
        
        UserRegistrationClass Register = new UserRegistrationClass(userName,gender,department,mobilenumber,mailId);
        System.Console.WriteLine();
        System.Console.WriteLine("\nUserName :"+userName+"\nUser Gender :"+gender+"\nUser Department :"+department+"\nUserMobileNumber :"+mobilenumber+"\nUser MailId :"+mailId);
        UserRegistrationList.Add(Register);
        }

        public static void UserLogin()
        {
            System.Console.WriteLine("Enter the UserId");
            object userId=Console.ReadLine();
            foreach(UserRegistrationClass id in UserRegistrationList)
            if( userId==UserRegistrationList)
            {
                System.Console.WriteLine("user Exist");
                SubMenu();
            }
            else
            {
                System.Console.WriteLine("User entered Invalid UserName");
            }
            
        }
        //SubMenu
         public static void SubMenu()
      {
        string  choice ="yes";
        do
        {
             System.Console.WriteLine("enter the Option \n 1. BorrowBook \n2. ShowBorrowedHistry 3.ReturnBooks ");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    BorrowBook();
                    break;
                }
                case 2:
                {
                    ShowBorrowedHistry();
                    break;
                }
            }
        }
        while(choice=="yes");
      }
      public  static void BookDetails() 
      {
        BookDetailsList.Add(new BookDetailsClass("C#","Author1",3));
        BookDetailsList.Add(new BookDetailsClass("HTML","Author2",5));
        BookDetailsList.Add(new BookDetailsClass("CSS","Author1",3));
        BookDetailsList.Add(new BookDetailsClass("JS","Author1",3));
        BookDetailsList.Add(new BookDetailsClass("Ts","Author2",2));
      }
      public static void UserDetails()
      {
        UserRegistrationList.Add(new UserRegistrationClass("Ravichandran",Gender.male,Department.EEE,9936190874,"ravi@gmail.com"));
        UserRegistrationList.Add(new UserRegistrationClass("Priyadharshini",Gender.female,Department.CSC,994445434,"priya@gmail.com"));
      }
      public static void ShowBorrowedHistry()
      {
        
      }
      public static void BorrowBook()
      {
        System.Console.WriteLine("Enter the Book User want to borrow");
        object bookid =Console.ReadLine();
        if(bookid==BookDetailsList)
        {

        }
        else
        {
            System.Console.WriteLine("books are not Available for the current count");
        }
      }
      }
     
    }
