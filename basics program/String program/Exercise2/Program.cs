using System;
    namespace Exercise2
    {
        class program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter the word");
                string word = Console.ReadLine();
                char[] word2= word.ToCharArray();   
                for (int i=0;i<word.Length;i++)
                {
                    Console.WriteLine(word2[i]+"");
                }
            }
        }
        
    }

