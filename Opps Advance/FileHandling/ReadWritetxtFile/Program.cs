using System;
using System.IO;
namespace ReadWritetxtFile;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder  Craeted");
        }
        else
        {
            System.Console.WriteLine("Folder exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created");
        }
        else
        {
            System.Console.WriteLine("File Found");
        }
        System.Console.WriteLine("Select Option 1.Read file 2. Write File");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader sr = null;  //Object creation for Streamreader
                try
                {
                    //PAss the file path and file name to the streamReader constructor
                    sr = new StreamReader("TestFolder/Test.txt");
                    //Read the first line of the text
                    line = sr.ReadLine();
                    while(line!=null)
                    {
                        //write the line to console window
                        System.Console.WriteLine(line);
                        //Read the next line
                        line = sr.ReadLine();
                    }
                }catch(Exception e)
                {
                    System.Console.WriteLine("Exception :"+e.Message);
                }
                finally
                {
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Executing ");sr.Close();
                    }
                }
                
                
                break;
            }
           
            case 2:
            StreamWriter sw=null;
            try
            { 
                string [] old =File.ReadAllLines("TestFolder/Test.txt");
                //Pass the filepath and filename to the streamwritter constructor to open
                sw= new StreamWriter("testFolder/Test.txt");
                System.Console.WriteLine("Enter the new Content");
                string info =Console.ReadLine();
                string old1="";
                foreach(string text in old)
                {
                    old1=old1+"\n"+text;//Append Old Text info
                }
                old1=old1+"\n"+info;//append our input test
                sw.WriteLine(old1);//WRITE fIILE
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Exception :"+e.Message);
            }
            finally
            {
                //close the file
                if(sw!=null)
                {
                    sw.Close();
                }
            }
            
                
                break;
            }
        }
        
    }


        
        
