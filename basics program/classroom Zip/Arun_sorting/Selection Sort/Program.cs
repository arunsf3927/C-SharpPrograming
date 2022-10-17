using System;
namespace SelectionSort;
class program
{
public static void Main(string[] args)
{
    int temp;
    int low;
    int[] arr = new int[] {1,6,2,8,3,5,5};
    for(int i=0;i<arr.Length-1;i++)
    {
        low= i;
        for(int j=i+1;j<arr.Length;j++)
        {
            if(arr[j]<arr[low])
            {
                low=j;
            }
        }
        temp = arr[low];
        arr[low]=arr[i];
        arr[i]=temp;
    }
    for(int i=0;i<arr.Length;i++)
    {
    System.Console.WriteLine(arr[i]);
    }
}
}