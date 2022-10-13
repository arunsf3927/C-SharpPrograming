using System;
namespace  word;
class Program
{   
  public static void Main(string[] args)
  {
    
    int flag =0;
    int[] word = new int[6]{'a','b','c','d','e','f'};
    Array.Sort(word);
    System.Console.WriteLine("enter the word want to search");
    char Character = char.Parse(Console.ReadLine());
    int first =0; int middle ;  int last=(word.Length-1);
    while(first<=last)
    {
        middle= (first + last)/2;
        if(word[middle]==Character)
        {
            System.Console.WriteLine($"present index of {middle}");
            last = middle;
            flag =1;
        }
        if(word[middle]>=Character)
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
    Console.WriteLine("word is not present");
    }
  } 
}

