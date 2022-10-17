using System;
namespace Exercise10
{
    class program10
    {
        public static void Main(string[] args)
        {
            do{

            
            string username,password;
            int ctr =0;
            Console.Write("username");
            username=Console.ReadLine();
            Console.Write("password");
            password=Console.ReadLine();
            if(username!="abcd"||password!="1234")
            ctr++;
            else
            {
                ctr=1;
            }
            while(username!="abcd"||password!="1234")
            if(ctr==3)
            Console.WriteLine("Trylater");
            else
            {
                Console.WriteLine("sucessfull");
            }

            }

        }
    }}
