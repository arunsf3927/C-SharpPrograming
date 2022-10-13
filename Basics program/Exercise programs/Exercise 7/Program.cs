using System;
namespace Exercise4
{
    class program
    {
     public static void Main(string[] args) 
     { 
        int s=2;
        Console.WriteLine("a");
        int a = int.Parse( Console.ReadLine());
        Console.WriteLine("b");
        int b = int.Parse( Console.ReadLine());
        double output =((a*a)+(s*a*b)+(b*b));
        Console.WriteLine("(a+b)^2 ="+output);
     }
    }
}


