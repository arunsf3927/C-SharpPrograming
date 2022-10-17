using System;
using System.Collections.Generic;
namespace  CollegeAdmission;
class Program
{
    public static void Main(string[] args)
    {
        List<StudentDetails> StudentList=new List<StudentDetails>();//create List
        

        System.Console.WriteLine("are you willing to join this college");
        string willing=Console.ReadLine().ToLower();
        while(willing=="yes")
        {
        //create  Object
 //Student1 
        Console.WriteLine("Enter Name :");
        string name =Console.ReadLine();
 

        Console.WriteLine("Enter  FatherName :");
        string fatherName =Console.ReadLine();
     

        Console.WriteLine("Enter Your DOB");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd//MM//yyyy",null);
     

        Console.WriteLine("Enter the Gender :");
        Gender gender =Enum.Parse<Gender>( Console.ReadLine(),true);
    

        Console.WriteLine("Enter phone number :");
        long phone =long.Parse(Console.ReadLine());
   

        Console.WriteLine("Enter the Mail :");
        string mail =Console.ReadLine();
     

        Console.WriteLine("Enter  Maths mark :");
        int maths =int.Parse(Console.ReadLine());
       

        Console.WriteLine("Enter  Chemistry mark :");
        int chemistry =int.Parse(Console.ReadLine());
       
       
        Console.WriteLine("Enter Physics mark :");
        int physics =int.Parse(Console.ReadLine());
    

        StudentDetails student1 =new StudentDetails(name,fatherName,dob,mail,phone,maths,physics,chemistry);
        StudentList.Add(student1);

        Console.WriteLine("Your name is :"+student1.Name+"\n Your fathername is :"+student1.FatherName+"\n Your DOB"+student1.DOB.ToString("dd//MM//yyyy")+"\n Your gender is :"+student1.Gender+"\n Phonenumber is :"+student1.Phone+"\n Your Mail is :"+student1.Mail+"\n Your maths mark :"+student1.Physics+"\n Your maths mark is :"+student1.Maths+"\n Your chemistry mark is :"+student1.Chemistry);
        

        bool eligible=student1.CheckEligibilty(75.0);
        if(eligible)
        {
            System.Console.WriteLine("Eligibile for admission");
        }
        else{
            System.Console.WriteLine("Not eligible");
        }
        System.Console.WriteLine("aru you willing to join this college");
        willing=Console.ReadLine().ToLower();
        }
       
    }
}

