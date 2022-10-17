using System;

using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionApplication
{
    public enum AdmissionStatus{Default,Booked,Cancelled}
    public class AdmissionDetail
    {
        static int s_admissionId=1000;
        
        public string AdmissionID { get;  }
        public string StudentID { get; }
        public string DepartmentId{ get; }
        public DateTime AdmissionDate { get; }
        public AdmissionStatus AdmissionStatus{ get; set; }

        public AdmissionDetail( string studentID,string departmentId,DateTime admissionDate,AdmissionStatus admissionStatus)
        {
            s_admissionId++;
            AdmissionID="AID"+s_admissionId;
            StudentID=studentID;
            DepartmentId=departmentId;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;
        }
        public AdmissionDetail (string data)
        {
            string[] values = data.Split(',');
            s_admissionId=int.Parse(values[0].Remove(0,2));
            StudentID=values[0];
            DepartmentId=values[1];
            AdmissionStatus=Enum.Parse<AdmissionStatus>(values[2]);
        }
       
        public void ShowAdmissionDetails()
        {
            System.Console.WriteLine("Admission ID:"+s_admissionId);
            System.Console.WriteLine("Student ID:"+StudentID);
            System.Console.WriteLine("Department ID:"+DepartmentId);
            System.Console.WriteLine("Admission Date:"+AdmissionDate);
            System.Console.WriteLine("Admission Status:"+AdmissionStatus);

        }
       
       




    }
}