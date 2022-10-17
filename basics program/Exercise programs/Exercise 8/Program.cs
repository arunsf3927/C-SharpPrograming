using System;
namespace Exercise4
{
    class program
    {
     public static void Main(string[] args) 
     { 
        Console.WriteLine("Enter Lenghth");
        double meter=double.Parse (Console.ReadLine());
        Console.WriteLine("Cm="+meter * 100);
        Console.WriteLine("Mm-"+(meter * 100)*10);
        Console.WriteLine("Inch-"+39.3 * meter);
        Console.WriteLine("Foot-"+12 * meter);
        Console.WriteLine("Mile-"+0.0006213715277778 * meter);
     }
    }
}
