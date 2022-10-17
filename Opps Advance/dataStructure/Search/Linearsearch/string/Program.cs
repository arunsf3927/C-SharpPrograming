using System;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        string[] words = new string[3] {"hello","hai","was"};
        System.Console.WriteLine("Enter the word want to search");
        string word=Console.ReadLine();
        int index = Linearsearch(words,word);   
        if(index<0)
        {
            System.Console.WriteLine("Not present");
        } 
        else
        {
            System.Console.WriteLine($"Present in the index{index}");
        }
    }
    public static int Linearsearch(string[]words,string a)
    {
        for (int i=0;i<words.Length;i++)
        {
            if(words[i]==a)
            {

              return i; 
            }
        }
    return -1;
    }
}
