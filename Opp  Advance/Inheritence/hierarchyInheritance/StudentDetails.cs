using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchyInheritance
{
    
    public enum Department{Default,ECE,EE,CSC}
    public class StudentDetails :PersonalDetails
    {
        private static int s_studentId=1000;
        public string StudentId{get;set;}
        public Department Department{get;set;}
        public string Year {get;set;}
        public StudentDetails(string adharId,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base(adharId,name,fatherName,gender,phoneNumber)
        {
            s_studentId++;
            Department=department;
            Year=year;
        }
        public void ShowStudent()
        {
            System.Console.WriteLine("student Id"+StudentId);
            ShowDetails();
            System.Console.WriteLine("department"+Department+"\n Year"+Year);
        }
    }
}