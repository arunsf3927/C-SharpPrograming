using System;
namespace BubbleSort;
class Program
{
    public static void Main(string[] args)
    {
        int[] BubbleSort = new int[] {10,2,5,20,4};
        for(int i = 0;i<BubbleSort.Length-1;i++)
        {
        for(int j=0;j<BubbleSort.Length-1;j++)
        {
            if (BubbleSort[j]>BubbleSort[j+1])
            {
               
            int temp = BubbleSort[j];
            BubbleSort[j]=BubbleSort[j+1];
            BubbleSort[j+1]=temp;
            }
        }
       
        }
         foreach(var item in BubbleSort)
        {
            System.Console.WriteLine(item);
        }
        
    }
}
