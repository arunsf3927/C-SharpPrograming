using System;
namespace Exercise2
{
    class program
    {
        public static void Main(string[] args)
        {
             int a=5;
            int b=6;
            int c=b;
            output();
            void output()
            {
               b=a;
               a=c;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            
        }
            
            }
}


