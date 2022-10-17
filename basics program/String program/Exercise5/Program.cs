using System;
    namespace  Exercise5
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter swntence1");
                string sentence1= Console.ReadLine();
                Console.WriteLine("Enter swntence1");
                string sentence2= Console.ReadLine();
                if(sentence1==sentence2&&sentence1.Length==sentence2.Length)
                {
                    Console.WriteLine("Equal");                   
                }
                else{
                    Console.WriteLine("not equal");
                }
            }
        }
    }