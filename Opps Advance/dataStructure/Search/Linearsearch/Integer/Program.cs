using System;
namespace Integer;
class Program
{
public static void Main(string[] args)
{
    int[] elememnts = new int[7] {1,4,2,6,4,7,9};
    System.Console.WriteLine("Enter the letter want to search");
    int search = int.Parse(Console.ReadLine());
   int index= LinearSearch(elememnts,search);
    if(index<0)
    {
        System.Console.WriteLine("not present");
    }
    else
    {
        System.Console.WriteLine($" Present in an array of {index}");
    }    
}
public static int LinearSearch(int[] elements, int a)
{
for(int i=0; i<elements.Length;i++)
{
    if(elements[i]==a)
    {
        System.Console.WriteLine("That elements present in index of :"+i);
        return i;
        }
}
return -1;
}

}
