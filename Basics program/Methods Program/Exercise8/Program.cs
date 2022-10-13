using System;
namespace Exercise6
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the mark1 ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark2 ");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark3 ");
            int c=int.Parse(Console.ReadLine());
            output();
            void output()
            {
           int Total =((a+b+c)/300)*100;
           Console.WriteLine("Total is :"+Total);
        
        }
            
            }
    }
}




