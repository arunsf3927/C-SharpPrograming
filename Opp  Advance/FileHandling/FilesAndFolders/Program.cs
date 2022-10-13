using System;
using System.IO;
namespace FilesAndFolders;
class Program
{
    public static void Main(string[] args)
    {
        string path =@"C:\Users\ArunSivakumar\OneDrive - Syncfusion\Desktop\MyFolder";//path
        string folderPath =path+"/Arun";//Inside that folder name
        string filePath = path+"/newFile.txt"; //foramteType
        if(!Directory.Exists(folderPath)) //Directory means Folder
        {
            System.Console.WriteLine("Folder not found .So create folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Directory Found");
        }
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not found . So create file");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File Found");
        }
        System.Console.WriteLine("Select Option 1.create Folder 2.create file 3.Delete Folder 4.Delete file");
        int num =int.Parse(Console.ReadLine());
        switch(num)
        {
            case 1:
            {
                System.Console.WriteLine("Enter  Folder you want to create");
                string name1=Console.ReadLine();
                string newpath =path+"\\"+name1;
                if(!Directory.Exists(newpath))
                {
                    Directory.CreateDirectory(newpath);
                }
                else
                {
                    System.Console.WriteLine("Directory name already exists");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter the File Name");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter the Extension Name");
                string extension=Console.ReadLine();
                string newpath=path+"\\"+fileName+"."+extension;
                if(!File.Exists(newpath))
                {
                    File.Create(newpath);
                }
                else
                {
                    System.Console.WriteLine("File Already Exists");
                } 
                break;
            }
            case 3:
            {
              foreach(string name in Directory.GetDirectories(path))  
             { System.Console.WriteLine(name);}
              System.Console.WriteLine("Enter the Folder name you want to delete");
              string name1= Console.ReadLine();
              string newpath =path+"\\"+name1;
              foreach(string name in Directory.GetDirectories(path))
              {
              if(name1==newpath)
              {
                try
                {
                Directory.Delete(newpath);
                System.Console.WriteLine("Folder Deleted");
                }
                catch(DriveNotFoundException e)
                {
                    System.Console.WriteLine("directory not Found");
                }
              }
              }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                    System.Console.WriteLine("Select file you want to  delete");
                    string name1=Console.ReadLine();
                    System.Console.WriteLine("Enter Extension");
                    string name2=Console.ReadLine();
                    string newPath = path+"\\"+name1+"."+name2;
                    foreach(string name in Directory.GetFiles(path))
                    {
                        if(name==newPath)
                        {
                            File.Delete(newPath);
                            System.Console.WriteLine(("File Deleted"));
                        }
                    }                    
                }
                break;
            }
            

            
        }
        
    }

