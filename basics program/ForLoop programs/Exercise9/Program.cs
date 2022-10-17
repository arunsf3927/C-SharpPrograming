using System;
namespace Forloop
{
    class program
    {
     public static void Main(string[] args) 
     {
        Console.WriteLine("enter the number");
        int number = int.Parse(Console.ReadLine());
        int Temp = number;
        int r,sum=0;
        for(int i=0;number>0;i++)
        {
          r=number%10;
          sum=sum+(r*r*r);
          number=number/10;
        }
        if(Temp == sum)
        {
            Console.WriteLine("Armstrong");
        }
        else
        {
            Console.WriteLine("Not an Armstrong number");
        }
        }
     }
}

