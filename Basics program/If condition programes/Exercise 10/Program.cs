// See https://aka.ms/new-console-template for more information
using System;
namespace Exercis9;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your User name");
        String Username=Console.ReadLine();
        if(Username=="HiTeam")
        {
            Console.WriteLine("Right Password");
        }
        else
        {
            Console.WriteLine("Wrong password");
        }
        
    }
}

