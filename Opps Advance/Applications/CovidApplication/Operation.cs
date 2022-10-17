using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApplication
{
    public class Operation
    {
         public static BeneficiaryClass curentBenificiary =null;
         public static List<BeneficiaryClass> benificiaryList=new List<BeneficiaryClass>();
        public static VaccinationClass currentVaccination=null;
        public static List<VaccinationClass> VaccinationList=new List<VaccinationClass>();
        public static VaccineClass currentVaccine= null;
        public static List<VaccineClass> VaccineList=new List<VaccineClass>();
        //MainMenu
        public static void MainMenu()
        {
        string choice="yes";
        do 
        {
        System.Console.WriteLine("select Option 1.Register 2.Login 4.Exit");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
        case 1:
        {
        System.Console.WriteLine("BenificiaryRegisteration");
        BeneficiaryRegistration();
        break;
        }
        case 2:
        {
        System.Console.WriteLine("Login");
        Login();
        break;
        }
        case 3:
        {
            System.Console.WriteLine("GetVaccinationInfo");
            VaccinationInfo();
            break;

        }
         case 4:
        {
        System.Console.WriteLine("Exit");
        choice="no";
        break;
     
       }
    
       }
       }
      while(choice=="yes");
        
    }
        
        //Registration
        public static void BeneficiaryRegistration()
        {
            System.Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            System.Console.WriteLine("neter the age");
            int age=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the Gender");
             Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

             System.Console.WriteLine("Enter the PhoneNumber");
             long mobileNumber=long.Parse(Console.ReadLine());

             System.Console.WriteLine("Enter the city");
             string city=Console.ReadLine();

             BeneficiaryClass benificiary = new BeneficiaryClass(name,gender,mobileNumber,city,age);

             benificiaryList.Add(benificiary);
             System.Console.WriteLine("RegisterationNumber is :"+(benificiary.RegisterationNumber));
        }
        //Login
        public static  void Login()
        {
            System.Console.WriteLine("Enter the Registration Number");
        string RegNumberUser=Console.ReadLine();
        foreach(var tempreg  in benificiaryList) 
        {
            if(RegNumberUser==tempreg.RegisterationNumber)
            {
                System.Console.WriteLine("login Succesfull");
                curentBenificiary=tempreg;
                SubMenu();
            }
            else
            {
                System.Console.WriteLine("Invalid Registration Number");
            }
        }
        }
         public static void SubMenu()
        {
            string choice ="yes";
            do{
            System.Console.WriteLine("select Option 1.Show My Details 2.Take vaccination 3.My Vaccination History 4.Next Due Date 5.Exit");
            int option = int.Parse(Console.ReadLine());
        switch(option)
        {
        case 1:
        {
        System.Console.WriteLine("Show My Details");
        MyDetails();
        break;
        }
        case 2:
        {
        System.Console.WriteLine("TakeVaccination");
        TakeVaccination();
        break;
        }
        case 3:
        {
            System.Console.WriteLine("GetVaccinationInfo");
            VaccinationInfo();
            break;

        }
         case 4:
        {
        System.Console.WriteLine("VaccinationHistory");
        MyVaccinationHistory();
        break;
        }
         case 5:
        {
        System.Console.WriteLine("VaccinationHistory");
        NextDueDate();
        break;
        }
         case 6:
        {
        System.Console.WriteLine("Exit");
        choice="no";
        break;
        }
        }
       }
      while(choice=="yes"); 
        }

        //VAccinationInfo
        public static void VaccinationInfo()
        {

        }
        public  static void MyDetails()
        {
            System.Console.WriteLine($"RegisterNumber{curentBenificiary.RegisterationNumber}\n Name :{curentBenificiary.Name}\n Mobile Number :{curentBenificiary.MobileNumber}\n Gender :{curentBenificiary.Gender}\n City :{curentBenificiary.City}\n Age :{curentBenificiary.Age}");
        }

        //TakeVaccination
        public static void TakeVaccination()
        {
            System.Console.WriteLine((VaccineList));
        }
        //MyVaccinationHistory
        public static void MyVaccinationHistory()
        {
            
        }
        //NextDuedate
        public static void NextDueDate()
        {

        } 
        //For Default values
        public static void DefaultBenificiary()
        {
            
            benificiaryList.Add(new BeneficiaryClass("Ravichandran",Gender.Male,8484484,"Chennai",21));
            benificiaryList.Add(new BeneficiaryClass("Baskaran",Gender.Male,8484747,"Chennai",22));

        } 
        public static void DefaultVaccine()
        {
            VaccineList.Add(new VaccineClass( VaccineName.Covishield,50));
            VaccineList.Add(new VaccineClass( VaccineName.Covaccine,50));
        }
        public static void DefaultVaccination()
        {
            VaccinationList.Add(new VaccinationClass("VID1001","BID1001",DoseNumber.one,new DateTime(11/11/2021)));
            VaccinationList.Add(new VaccinationClass("VID1002","BID1002",DoseNumber.two,new DateTime(11/03/2021)));
            VaccinationList.Add(new VaccinationClass("VID1003","BID1003",DoseNumber.one,new DateTime(04/04/2021)));
        }
    }
}