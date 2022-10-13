using System;
namespace Studentsdata
{
    class program
    {
     public static void Main(string[] args)  
     {
         Console.WriteLine("Enter the student name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the father name:");
        string fathername=Console.ReadLine();
        Console.WriteLine("Enter your gender:");
        char gender=char.Parse(Console.ReadLine());
        Console.WriteLine("mail id");
        object mailid= Console.ReadLine();
        Console.WriteLine("phone number");
        long phonenumber= int.Parse(Console.ReadLine());
        Console.WriteLine("age");
        int age= int.Parse (Console.ReadLine());
        Console.WriteLine("chemisty mark");
        float chemisty= float.Parse(Console.ReadLine());
        Console.WriteLine("physis mark");
        float physis= float.Parse(Console.ReadLine());
        Console.WriteLine("maths mark");
        float maths= float.Parse(Console.ReadLine());
        Console.WriteLine("name:"+name+ " father name: "+fathername+ " gender: "+gender+ " mail id: "+mailid+ " phone number: "+phonenumber +age+" age: ");
        Console.WriteLine(" your Averge mark is:"+((chemisty+physis+maths)/3));
        Console.WriteLine(" your percentage is:"+(((chemisty+physis+maths)/600)*100)+"%");
       

     } 
    }
    
}
