// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise6;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Temperature");
        float temperature=float.Parse(Console.ReadLine());
    if(temperature<0)
    {
        Console.WriteLine("Its freezing wheather");
    }
    else if(temperature<=0&&temperature>10)
    {
        Console.WriteLine("Its Very cold");
    }
    else if(temperature<=10&&temperature>20)
    {
     Console.WriteLine("Its cold wheather");   
    }
    else if(temperature<=20&&temperature>30)
    {
        Console.WriteLine("Its Normal Temperature");
    }
    else if(temperature<=30&&temperature>=40)
    {
        Console.WriteLine("Its Hot");
    }
    else if(temperature>=40)
    {
        Console.WriteLine("Its Very Hot");
    }
    }
}
