// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise1
{
    class program
    {
        
        public static void Main(string[] args)
        {
            string con="";
            int Sum ;
            int Product;
            int divide;
            int sub;
            do
            {
                                   
                Console.WriteLine("Enter the option to perform");
                int option =int.Parse (Console.ReadLine());
                Console.WriteLine("Enter number1");
                int number1=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number2");
                int  number2=int.Parse(Console.ReadLine()); 
              
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Addition:"+Addition( number1, number2));
                        break;
                    }
                    case 2:
                    {
                        Subraction(number1,number2);
                        break;
                    }
                    case 3:
                    {
                        Multiplication(number1,number2);
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine(Division(number1,number2));
                        break;
                    }
                }
                Console.WriteLine("If  you want to Repeat the process ");
                con =Console.ReadLine().ToLower();
            }
            
             while(con =="yes");
             
            //with Arguement without Return type
            int Addition(int value1 , int value2)
            {
                Sum = (value1 + value2);
                return Sum;
            }
            //with Arguement without Return type
            void Multiplication(int value1 , int value2)
            {
                Product =(value1 *value2);
                Console.WriteLine("Multiplication: "+Product);
            }
              //Without Argurment with Return type 
              int Division (int value1 , int value2)
              {
                divide =(value1/value1);
                return divide;
              }
             //without arguement without return type
                void Subraction(int number1, int number2)
                {
                    sub =(number1-number2);
                    Console.WriteLine("Subraction is :"+sub);
                }
             }
            
           
            

        }
    }

