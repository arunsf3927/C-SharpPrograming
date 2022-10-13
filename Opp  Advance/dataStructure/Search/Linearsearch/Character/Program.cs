using System;
namespace Integer;
class Program
{
public static void Main(string[] args)
{
    char[] characters = new char[3] {'a','b','e'};
    System.Console.WriteLine("Enter the Element want to search");
    char search = char.Parse(Console.ReadLine());
   int  index= LinearSearch(characters,search);
    if(index<0)
    {
        System.Console.WriteLine("not present");
    }
    else
    {
        System.Console.WriteLine($" Present in an array of {index}");
    }    
}
public static int LinearSearch(char[] characters, int a)
{
for(int i=0; i<characters.Length;i++)
{
    if(characters[i]==a)
    {
        System.Console.WriteLine("That elements present in index of :"+i);
        return i;
        }
}
return -1;
}

}

