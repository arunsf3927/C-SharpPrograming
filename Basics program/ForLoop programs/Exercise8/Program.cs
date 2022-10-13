using System;
namespace Exercise1
{
    class program
    {
        public static void Main(string[] args)
        {
            
            for(int i =0;i<=4;i++)
            {
                 for(int j=0;i<=4-i;j++)
            {
               System.Console.Write(" ");
            }
             for(int k=1;k<=2*i-1;k++)
            {
            System.Console.Write((i-1)+k);
            System.Console.Write(" ");
            } 
            System.Console.WriteLine("");     
            }
        }
    }

}


