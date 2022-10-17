using System;
namespace  String;
class Program
{   
  public static void Main(string[] args)
  {
    
    int flag =0;
    string[] String = new string[] {"hai","hello","thanks","good"};
    Array.Sort(String);
    System.Console.WriteLine("enter the String want to search");
    string letter = (Console.ReadLine());
    int first =0; int middle ;  int last=(String.Length-1);
    while(first<=last)
    {
        middle= (first + last)/2;
        if(String[middle]==letter)
        {
            System.Console.WriteLine($"present index of {middle}");
            last = middle;
            flag =1;
        }
        if(string.Compare(letter,String[middle])<1)
        {
            last = middle-1;
        }
       else
        {
            first = middle+1;
        }
    }
    if(flag!=1)
    {
    Console.WriteLine("String is not present");
    }
  } 
}
