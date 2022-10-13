using System;
using System.Collections.Generic;
using System.IO;
namespace ListFileManupulation;
class Program
{
    public static void Main(string[] args)
    {
        List<StudentDetails>  studentList= new List<StudentDetails>();
        studentList.Add(new StudentDetails(){Name ="Ravi",FatherName="chandran",Gender=Gender.Male,DOB=new DateTime()});
        studentList.Add(new StudentDetails(){Name ="Arun",FatherName="FR",Gender=Gender.Male,DOB=new DateTime()});
        studentList.Add(new StudentDetails(){Name ="Vignesh",FatherName="Raman",Gender=Gender.Male,DOB=new DateTime()});
        Insert(studentList);
        Display();

    }
    static void Insert(List<StudentDetails> studentList)
    {
        StreamWriter write = null;
        if(!File.Exists("DAta.csv"))
        {
            System.Console.WriteLine("File Does'nt exist Create new csv File");
            File.Create("Data.csv");
        }
        else
        {
            System.Console.WriteLine("file Found");
        }
        write = new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var v in studentList)
        {
            write .WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.DOB.ToString("dd/MM/yyyy"));
        }
    write.Close();
        
    }
    static void Display()
    {
        StreamReader reader=null;
        List<StudentDetails> listA=new List<StudentDetails>();
        if(File.Exists("Data.csv"))
        {
            reader = new StreamReader(File.OpenRead("Data.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(",");
                if(values[0]!="")
                {
                    listA.Add(new StudentDetails(){Name=values[0], FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                }
               
            }
        }
        else
            {
            System.Console.WriteLine("File Does Not exist");
            }
            reader.Close();
            foreach(var coloumn1 in listA)
            {
            System.Console.WriteLine("Your  Name :\t"+coloumn1.Name+"\t FatherName :\t"+coloumn1.FatherName+"\t Gender \t"+coloumn1.Gender,"\t DOB"+coloumn1.DOB.ToString("dd/MM/yyyy"));
            }
    }
}
