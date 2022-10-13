using System;
namespace Exercise6
{
class program
{
    public static void Main(string[] args)
    {
     int n=1;
      while(n>0)
      {
         for(int i=1;i<=100;i++)
         {
        if (i%2==0)
        {
            Console.WriteLine(i+" is a Prime Number");
        }
        else
        {
            Console.WriteLine(+i+" is a odd Number");
        }
         }
         n--;
      }
       
    }
}
}
