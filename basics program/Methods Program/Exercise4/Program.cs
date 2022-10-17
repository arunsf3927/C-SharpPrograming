using System;
namespace Exercise4
{
    class program
    {
        public static void Main(string[] args)
        {
             int f=15;
             int a=0;
             int b=1;
             int c=0;
            output();
            void output()
            {
             for(int i=0;i<=f;i++)
             {
                c=a+b;
                Console.WriteLine(c);
                a=b;
                b=c;
                i++;
                
                
             } 
            
        }
            
            }
    }
}



