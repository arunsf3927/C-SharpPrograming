using System;
namespace Array
    {
     class program   
     {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the Array");
            int size= int.Parse(Console.ReadLine());
            string[] names = new string[size];
            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine("Enter the names");
                names[i]=Console.ReadLine();   
            }
            for(int i=0;i<size;i++)
            {
             Console.WriteLine(names[i]);
            }
            Console.WriteLine("Enter the names to search");
             string search=Console.ReadLine(); 
             int temp =0; 
            for (int i =0;i<size;i++)
            {
                if(names[i]==search)
                {
                Console.WriteLine("The name is present in array And the index number  is :" +i);
                temp ++;
                }
            }
            if(temp ==0)
                {
                     Console.WriteLine("The name is not present in the array" );
                }
                int temp2=0;
                foreach(string ArrayNames in names)
                {
                    if(ArrayNames==search)
                    {
                    Console.WriteLine("The name is present in the array");
                    temp2 =1;
                    }
                }
            if(temp2 ==0)
                {
                Console.WriteLine("The name is not present in the array");
                }

                
            
        
            
        }      
            
        }
     }
