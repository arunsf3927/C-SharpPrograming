using System;
namespace Exercise6
{
    class program
    {
      public static void Main(string[] args)
      {
        char a='*';
        for (int i=1;i<=4;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.WriteLine($"{a}");
                Console.WriteLine("\n");
            }
        }
      }
    }
}
