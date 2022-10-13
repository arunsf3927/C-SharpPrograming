using System;
namespace InsertionSort;
class Program
{
 public static void Main(string[] args)
 {
    int[] InsertionSort = new int[]{20,40,1,5,2};
    int temp =0;
    int key;
    int j;

    for(int i=1;i<InsertionSort.Length;i++)
    {
        key =InsertionSort[i];
        j=i-1;
        while(j>=0 && key<InsertionSort[j])
        {
            temp= InsertionSort[j];
            InsertionSort[j]=InsertionSort[j+1];
            InsertionSort[j+1]= temp;
            j--;
        }
        
          
    }
    foreach(var item in InsertionSort)
        {
            System.Console.WriteLine(item);
        }
 }   
}
