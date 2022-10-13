using System;
using System.IO;

using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionApplication
{
    public  static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine(("creating Folder"));
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv")&&(!File.Exists("College/DepartmentDetails.csv")&&(!File.Exists("College/CollegeAdmissionDetails.csv"))))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/StudentDetails.csv");
                File.Create("College/DepartmentDetails.csv");
                File.Create("College/CollegeAdmissionDetails.csv");
            }
        }
        public static  void ReadFile()
            {
                string[] student=File.ReadAllLines("College/StudentDetails.csv") ;
                foreach (string data in student)
                {
                    StudentDetails student1=new StudentDetails(data);
                    Operations.StudentList.Add(student1);
                }
                   string[] department=File.ReadAllLines("College/DepartmentDetails.csv");
                   foreach(string data1 in department)
                   {
                    DepartmentDetails department1=new DepartmentDetails(data1);
                    Operations.DepartmentList.Add(department1);
                   }
                   string[] Admission = File.ReadAllLines("College/CollegeAdmissionDetails.csv");
                   foreach (string data2 in Admission)
                   {
                    AdmissionDetail admission1 = new AdmissionDetail(data2);
                    Operations.AdmissionList.Add(admission1);
                   }
            }
        public static void WriteToFiles()
        {
            string[] studentDetails=new string [Operations.StudentList.Count];
            for(int i=0;i<Operations.StudentList.Count;i++)
            {
                studentDetails[i]=Operations.StudentList[i].RegisterNumber+","+Operations.StudentList[i].Name+","+Operations.StudentList[i].FatherName+","+Operations.StudentList[i].DateofBirth+","+Operations.StudentList[i].Gender+","+Operations.StudentList[i].Phonenumber+","+Operations.StudentList[i].MailId+","+Operations.StudentList[i].Physics+","+Operations.StudentList[i].Chemistry+","+Operations.StudentList[i].Mathematics;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);
            string [] departmentDetails = new string [Operations.DepartmentList.Count];
            for (int i=0;i<Operations.StudentList.Count;i++)
            {
                departmentDetails[i]=Operations.DepartmentList[i].DepartmentId+","+Operations.DepartmentList[i].Departments+","+Operations.DepartmentList[i].NumberOfSeats;
            }
            File.WriteAllLines("College/DepartmentDetails.csv",departmentDetails);
            string[] admissionDetails = new string [Operations.DepartmentList.Count];
            
        }
        
    }
}