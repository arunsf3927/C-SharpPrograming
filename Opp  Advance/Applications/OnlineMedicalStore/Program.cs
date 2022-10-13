using System;
namespace OnlineMedicalStore;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        Operation.MainnMenu();
        Files.WriteToFiles();
        List<int> datas=new List<int>();
        datas.Add(45);
        datas.Add(55);
        datas.Add(5);
        datas.Add(4);
        datas.Add(6);
        datas.Insert(2,45);
        datas.Remove(1);
        datas.RemoveAt(3);  
        foreach(int data in datas)
        {
        System.Console.WriteLine(data);    
        }
        for(int i=0;i<datas.Count;i++)
        {
            System.Console.WriteLine(datas[i]);
        }
    
    }
}