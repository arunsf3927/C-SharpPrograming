using System;
namespace Exercise3
{
    class program
    {
        public static void Main(string[] args)
        {
        int c; int i=3; int a=0; int b=1;
        Console.WriteLine("enter the number :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("0");
        Console.WriteLine("1");
        do
        {
          c=a+b;
          Console.WriteLine(c);
          a=b;
          b=c;
          i++;
        }
        while(i<=n);
        Console.ReadLine();        }
    }
}
