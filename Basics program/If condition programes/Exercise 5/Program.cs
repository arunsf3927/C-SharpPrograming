// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise5;
class program
{
public static void Main(string[] args)
{
    int calculation =0;
    Console.WriteLine("Enter Physics mark");
    int Physics =int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Chemistry mark");
    int Chemistry =int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Mathametics mark");
    int Mathametics =int.Parse(Console.ReadLine());
    calculation = (((Physics+Chemistry+Mathametics)/300)*100);
    if(calculation>=75)
    {
        Console.WriteLine("The candidate is eligible for admission.");
    }
    else
    {
       Console.WriteLine("The candidate is  not eligible for admission.");
    }
    {
        
    }
}
}
