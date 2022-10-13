using System;
namespace Exercise2
{
    class program
    {
     public static void Main(string[] args) 
     {
         int Result = 0;
        int i =1;
        Console.WriteLine("count");
        int count = int.Parse( Console.ReadLine());
        while(i<=count)
        {
         Result +=(i*i);
         i++;
        }
         Console.WriteLine(Result);
     }
    }
}