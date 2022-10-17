using System;
namespace Exercise8
{
    class program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("enter the word");
          string word=Console.ReadLine();
          output();
          void output()
          {
            for(int i=0;i<word.Length;i--)
            {
                string word2=Console.ReadLine();
                if(word==word2)
                {
                    Console.WriteLine("palindrome");
                    i=0;
                }
                else
                {
                 Console.WriteLine("not palindrome");
                 i=0;
                }
             }
            }
            
        }
    }
}