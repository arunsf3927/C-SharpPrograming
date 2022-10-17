using System;
namespace Exercise6
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int f=int.Parse(Console.ReadLine());
            int  factorial=f;
            output();
            void output()
            {
             for(int i=1;i<f;i++)
             {
                factorial=factorial*i;
                
             } 
             Console.WriteLine("The factorial of a number is"+factorial);
            
        }
            
            }
    }
}



