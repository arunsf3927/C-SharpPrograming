using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employement;
    public class Operations
    {
        List<PersonalDetails> PersonalDetailsList= new List<PersonalDetails>();
        public static  void Application()
        { 
        System.Console.WriteLine("Enter Your Name:");
        string name=Console.ReadLine();

        System.Console.WriteLine("Enter Father Name: ");
        string fatherName=Console.ReadLine();
        
        System.Console.WriteLine("Enter Your gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Enter your phone number:");
        long phoneNumber=long.Parse(Console.ReadLine());

         PersonalDetails details=new PersonalDetails(name,fatherName,gender,phoneNumber);
         PersonalDetailsList.Add(details);   
        }
        
         
    }

