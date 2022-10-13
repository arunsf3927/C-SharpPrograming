using System;
namespace Exercise3
{
    class program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Enter the word");
                string word = Console.ReadLine();
                char[] word2= word.ToCharArray();   
                for (int i=word2.Length;i>0;i--)
                {
                    string final=(word2[i]+"");
                    Console.WriteLine(final);
                }
        }
    }
}
