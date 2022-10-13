// See https://aka.ms/new-console-template for more information
using System;
namespace Exercis9;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the month");
        string month= Console.ReadLine();
        if(month =="December"||month=="January"||month=="February")
        {
            Console.WriteLine("Winter");
        }
        else if(month=="March"||month=="April"||month=="may")
        {
            Console.WriteLine("Spring");
        }
        else if(month=="June"||month=="July"||month=="May")
        {
            Console.WriteLine("Summer");
        }
        else if(month =="September"||month=="October"||month=="November")
        {
            Console.WriteLine("Rainfall");
        }
    }
}