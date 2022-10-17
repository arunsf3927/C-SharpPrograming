using System;
namespace Exercise6
{
    class program
    {
     public static void Main(string[] args) 
     { 
        Console.WriteLine("Price");
        float price = float.Parse( Console.ReadLine());
        double Total = (price+price*0.18);
        Console.WriteLine(Total);
         }
    }
}

