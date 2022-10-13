using System;
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum =0;
             Console.WriteLine("enter range");
             int n = int.Parse(Console.ReadLine());
             for(int i=1;i<=n;i++)
             {
            sum = (sum +i);
            Console.WriteLine("Output sum :" +sum);
             }
        }
    } 
}
