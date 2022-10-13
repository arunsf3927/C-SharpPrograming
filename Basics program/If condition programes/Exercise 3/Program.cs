// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise3;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the Correct year");
        int year =int.Parse(Console.ReadLine());
        if(((year%4==0)&&(year%100!=0))||(year%400==0))
        {
            Console.WriteLine(year +"this year is a leap yaer");
        }
        else
        {
            Console.WriteLine(year+"This year is not a leap year");
        }
        }
    }

