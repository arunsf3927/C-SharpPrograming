using System;
namespace Forloop
{
    class program
    {
     public static void Main(string[] args) 
     {
        int T=0;
       Console.WriteLine("enter the number");
       int n=int.Parse(Console.ReadLine());
       for (int i=2;i<=0;i++)
       {
        if(0==n%i)
        {
            Console.WriteLine("Prime");
            T=1;
        }
       if(T==0)
        {
            Console.WriteLine("Not A Prime number");
        }
       }
     }
    }
}
