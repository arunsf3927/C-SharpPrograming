using System;
namespace Forloop
{
    class program
    {
     public static void Main(string[] args) 
     {
        int i;
        Console.WriteLine("enter range");
        int n = int.Parse(Console.ReadLine());
        for ( i=1;i<=n;i++)
        {
            Console.WriteLine(i);
        }
     }
    }
}
