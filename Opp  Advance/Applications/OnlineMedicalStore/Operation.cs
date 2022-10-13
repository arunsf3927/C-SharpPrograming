using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class Operation
    {
         public static UserDetailsClass currentUser=null;
        public static List<UserDetailsClass> UserDetailsList=new List<UserDetailsClass>();
         public static MedicineDetailsClass currentMedicine=null;
         public static List<MedicineDetailsClass> MedicineDetailList=new List<MedicineDetailsClass>();
         public static OrderDetailsClass currentOrder=null;
         public static List<OrderDetailsClass> OrderList=new List<OrderDetailsClass>();
         public static  void MainnMenu()
         {
            System.Console.WriteLine("********OnlineMedicalStotre**********");
            string choice ="yes";
            do
            {
            System.Console.WriteLine("Enter the option  1.UserRegistration 2.UserLogin 3.OrderHistory");
            int Option =int.Parse(Console.ReadLine());
            switch(Option)
            {
                case 1:
                {
                    System.Console.WriteLine("UserRegistration");
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("UserLogin");
                    UserLogin();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("OrderHistory");
                    break;
                }
                case 4:
                
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
              
            }
            }
            while(choice=="yes");
            
         }

         public static void UserRegistration()
         {
            System.Console.WriteLine("Enter UserName");
            string userName=Console.ReadLine();

            System.Console.WriteLine("Enter the User Age");
            int age=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter City");
            string city = Console.ReadLine();

            System.Console.WriteLine("Enter the PhoneNumber");
            long phoneNumber=long .Parse (Console.ReadLine());

            System.Console.WriteLine("Enter the Balnce");
            double balance=double.Parse (Console.ReadLine());

            UserDetailsClass userDetail = new UserDetailsClass(userName,age,city,phoneNumber,balance);   //ObjectCreation
            UserDetailsList.Add(userDetail); 
         }

         public static void UserLogin()
         {
            System.Console.WriteLine("Enter the UserID");
            object userId=Console.ReadLine();
            if(currentUser.UserId==userId)
            {
                System.Console.WriteLine("Logined Succesfully");
                Submenu();
            }
            else
            {
                System.Console.WriteLine("Invaild UserId");
            }
         }
         public static void Submenu()
         {
            string choice ="yes";
         do
        {     
        System.Console.WriteLine("Enter the Option");
         int option2=int.Parse(Console.ReadLine());
         switch(option2)
         {
            case 1:
            {
                System.Console.WriteLine("Show Medicine List");
                ShowMedicineList();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Purchase Medicine");
                PurchaseMedicine();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Cancel Purchase");
                CancelPurchase();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Show Purchase History");
                ShowPurchaseHistory();
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Recharge");
                Recharge();
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Exit");
                choice ="no";
                break;
            }
           }  
        }
        while(choice=="yes") ;
        }
        public static void ShowMedicineList()
        {
            foreach(MedicineDetailsClass medicine in MedicineDetailList)
            {
                System.Console.WriteLine("MedicineId :"+medicine.MedicineId+"Medicine Name :"+medicine.MedicineName+"Price :"+medicine.Price+"Medicine Available Count :"+medicine.AvailableCount+"MEdicine Expiry date :"+medicine.DateOfExpiry);
            }
        }
        public static void PurchaseMedicine()
        {
            System.Console.WriteLine("Enter the medicineId");
            object medicineID=Console.ReadLine();
            if(currentMedicine.MedicineId==medicineID)
            {
                System.Console.WriteLine("Correct MedicineId");
            }
        }
         public static void CancelPurchase()
        {

        }
        public static void ShowPurchaseHistory()
        {

        }
        public static void Recharge()
        {

        }
    }
}