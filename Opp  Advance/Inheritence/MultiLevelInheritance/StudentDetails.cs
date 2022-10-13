using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public enum Department{Default,ECE,EE,CSC}
    public class StudentDetails :PersonalDetails,IMarkDetails
    {
        private static int s_studentId=1000;
        public string StudentId{get;set;}
        public Department Department{get;set;}
        public string Year {get;set;}
        //added
        public int Physics {get;set;}   
        public int Chemistry {get;set;}
        public int Maths {get;set;}
        public int Total {get;set;}
         public double Average {get;set;}
     
        public StudentDetails(string adharId,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base(adharId,name,fatherName,gender,phoneNumber)
        {
            s_studentId++;
            Department=department;
            Year=year;
        }
        //added
        public StudentDetails(string studentId, string adharId,string name,string fatherName,Gender gender,long phoneNumber,Department department):base(adharId,name,fatherName,gender,phoneNumber)
        {
            StudentId=studentId;
            Department=department;
         
        }
        //
        public void GetMark(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void Calculation()
        {
            Total=Physics+Chemistry+Maths;
            Average=(double) Total/3.0;
        }
        public void ShowMark()
        {
            System.Console.WriteLine("Physics"+Physics,"Chemistry"+Chemistry,"Maths"+Maths);
            System.Console.WriteLine("Total"+Total,"Average"+Average);
        }
        //
        public void ShowStudent()
        {
            System.Console.WriteLine("student Id"+StudentId);
            ShowDetails();
            System.Console.WriteLine("department"+Department+"\n Year"+Year);
        }
    }
}
