using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public enum Department{Default,ECE,EE,CSC}
    public class StudentDetails :PersonalDetails,IMarkDetails
    {
       private static int s_registernumber=3000;
        
        public string RegisterNumber { get;  }
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DateofBirth { get; set; }
        public Gender Gender { get; set; }
        public long Phonenumber { get; set; }
        public string MailId { get; set; }

        public StudentDetails(string name,string fatherName ,DateTime datofBirth,Gender gender,long PhoneNumber,string mailId,int physics,int chemistry,int maths )
        {
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Branch =branch;
            AcademicYear=acad
     
}
