using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmployementDetails:StudentDetails
    {
        private static int s_employementId = 1000;
        public string EmployeMentId{get;set;}
        public DateTime RegisterationDate {get;set;}
        public EmployementDetails(string studentId, string adharId,string name,string fatherName,Gender gender,long phoneNumber,Department department):base(studentId,adharId,name,fatherName,gender,phoneNumber,department)
        {
            s_employementId++;//added
            EmployeMentId="EID"+s_employementId;
            RegisterationDate=DateTime.Now;
        }//added
        public void ShowEmployeMentDetails()
        {
            System.Console.WriteLine(EmployeMentId);
            ShowStudent();
            System.Console.WriteLine(RegisterationDate.ToString("dd/MM/yy"));
        }
    }
}