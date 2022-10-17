using System;
namespace StringProgram;
class StringProgram
{
public static void Main(string[] args)
{  string Lenghth="";
    Console.WriteLine("Enter a Main String");
    string Main = Console.ReadLine();
    Console.WriteLine("Enter the sub String");
    string sub =Console.ReadLine();
    string[] main1=Main.Split(sub);
    foreach (String i in main1 )
    {
        Lenghth=Lenghth+i;
    }
    Console.WriteLine(Lenghth.Length);
   
   }
}
