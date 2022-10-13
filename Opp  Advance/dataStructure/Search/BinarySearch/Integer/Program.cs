using System;
namespace  Integer;
class Program
{   
  public static void Main(string[] args)
  {
    
    int flag =0;
    int[] integer = new int[6]{1,2,3,4,5,6};
    Array.Sort(integer);
    System.Console.WriteLine("enter the word want to search");
    int number = int.Parse(Console.ReadLine());
    int first =0; int middle =0;  int last=(integer.Length-1);
    while(first<last)
    {
        middle= (first + last)/2;
        if(integer[middle]==number)
        {
            System.Console.WriteLine($"present {integer[middle]}");
            last = middle;
            flag =1;
        }
        if(integer[middle]>=number)
        {
            last = middle-1;
        }
        if(integer[middle]<=number)
        {
            first = middle+1;
        }
    }
    if(flag!=1)
    {
    Console.WriteLine("element not present");
    }
  } 
}
