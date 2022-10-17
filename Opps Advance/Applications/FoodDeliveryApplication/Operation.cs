using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication;

    public class Operation
    {
        public static PersonalDetailsClass  currentPerson=null;
        public static List<PersonalDetailsClass> PersonalDetailsList=new List<PersonalDetailsClass>();
        public static IBalance currentBalance=null;
        public static List<IBalance> InterfaceIBalancesList =new List<IBalance>();
        public static CustemerRgistrationClass currentcustemer=null;
        public static List<CustemerRgistrationClass> CustemerRgistrationList=new List<CustemerRgistrationClass>();
        public static void MainMenu()
        {
            System.Console.WriteLine("FoodDeliveryApplication");
          
            string choice ="yes";
            do
            {
            System.Console.WriteLine("Enter the Option 1.CustomerRegistration 2.CustomerLogin 3.Exit");
            int option =int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("CustomerRegistration");
                        CustemerRgistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("CustemorLogin");
                        CustomerLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Enter Exit");
                        choice="no";
                        break;
                    }
                }
            }
              while(choice=="yes");
        }
          public static void CustemerRgistration()
          {
            System.Console.WriteLine("Enter Name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter FatherName");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Gender");
            Gender gende=Enum.Parse<Gender>(Console.ReadLine());
            System.Console.WriteLine("MobileNumber");
            long mobileNummber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("DateOfBirth");
            DateTime dob=DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("MailId");
            string mailId=Console.ReadLine();
            System.Console.WriteLine("Enter Location");
            string location = Console.ReadLine();
            System.Console.WriteLine("Enter balance");
            int walletBalance=int.Parse(Console.ReadLine());
            CustemerRgistrationClass Personal1 =new CustemerRgistrationClass( name,fatherName,Gender.male,mobileNummber,dob,mailId,location,walletBalance);
            CustemerRgistrationList.Add(Personal1);
            System.Console.WriteLine("Custemerid :"+Personal1.CustemerId);
          }
          public static void CustomerLogin()
          {
            System.Console.WriteLine("enter CustemerId");
            string custemerId1=Console.ReadLine();
            int flag=0;
            foreach(CustemerRgistrationClass person in CustemerRgistrationList)
            {
               if(custemerId1==person.CustemerId)
               {
                System.Console.WriteLine("Login successfull");
                currentcustemer=person;
                SubMenu();
                flag++;
               }
            }
             if(flag==0)
             {
                System.Console.WriteLine("invalid LogoinId");
             }
          }
          public  static void SubMenu()
          {
             string choice="yes";
        do
                        {
                            System.Console.WriteLine("SubMenu 1.ShowFoodIteam 2.OredrFood 3.CancelBooking 4.OrderHistory 5. Reacharge .Exit");
                            int option=int.Parse(Console.ReadLine());
                                switch (option)
                                { 
                                    case 1:
                                      {
                                        System.Console.WriteLine("ShowFoodIteam");
                                       
                                        break;
                                    }
                                    case 2:
                                    {
                                        System.Console.WriteLine("OrderFood");
                                        
                                        
                                        break;
                                    }    
                                    case 3:
                                    {
                                        System.Console.WriteLine("Cancel Booking");
                                        
                                    
                                        break;
                                    }
                                    case 4:
                                    {
                                        System.Console.WriteLine("Order history");
                                       
                                        break;
                                    }
                                    case 5:   
                                    {
                                        System.Console.WriteLine("Recharge");
                                       
                                        break;
                                    }
                                    case 6:
                                    {
                                        System.Console.WriteLine("Exit ");
                                        
                                        break;
                                    }
                                    default:
                                        break;
                                    
                                }
                            }
                            while(choice=="yes");    
                          
          }
          public static void ShowFoodIteam()
           {
            
           } 
          
         
    }
