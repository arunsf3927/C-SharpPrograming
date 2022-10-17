using System;
namespace Exercise2
{
    class program
    {
     public static void Main(string[] args) 
     {
         int number1 = 0;
         int number2=1;
         int newnumber;
        int i =0;
        Console.WriteLine("count");
        int count = int.Parse( Console.ReadLine());
        while(i<=count)
        {
         newnumber=(number1+number2);
         number1=newnumber;
         number1=number2;
        i++;
        }
         
     }
    }
}
