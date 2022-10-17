// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise8;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter sugar level in text");
        int input = int.Parse(Console.ReadLine());
        if(input<90)
        {
            Console.WriteLine("Low sugar");
        }
        else if(input<=90&&input>=130)
        {
         Console.WriteLine("Normal");
        }
        else if(input>=130&&input<=140)
    {
        Console.WriteLine("medium");
    }
    else if(input>=140&&input<=170)
    {
        Console.WriteLine("high Sugar----Try to reduce it from now");
    }
    else if(input>=170)
    {
        Console.WriteLine("You are a very high Sugar Patient");
    }
    else
    {
      Console.WriteLine("Enter valid input");
    }
    }
}
