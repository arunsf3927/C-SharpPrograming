using System;

using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionApplication
{
    public delegate void EventManager(); 
    public static class Operations
    {
        public static event EventManager eventlink = null;
        public static StudentDetails currentStudent=null;
        public  static List<StudentDetails> StudentList=new List<StudentDetails>();
        public static DepartmentDetails currentDepartment=null;
        public static List<DepartmentDetails> DepartmentList=new List<DepartmentDetails>();
        public static AdmissionDetail currentAdmission=null;
        public static List<AdmissionDetail> AdmissionList=new List<AdmissionDetail>();
        public static void Subscribe()
        {
            eventlink+= new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(Operations.Mainmenu);
            eventlink+=new EventManager(Files.WriteToFiles);
        }
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }


        public static void Mainmenu()
        {
            
            string choice="yes";
            do
            {
                Console.WriteLine("Select Option1.Student YourRegistration 2.Student Login 3.Check Department wise seat availability 4.Exit");
                int option=int.Parse(Console.ReadLine());
            switch (option)
               {
                case 1:
                
                  System.Console.WriteLine("Your YourRegistration Process");
                    YourRegistration();
                    
                    break;
                
                case 2:
                
                    System.Console.WriteLine("Login");
                    Login();
                    
                    break;

                case 3:
                    System.Console.WriteLine("Seat Availablity");
                    DepartmentData();
                    break;
                   
                case 4:
                
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
              
                default:
                
                    break;
                
                }
                
        }while(choice=="yes");

        }
         public static void YourRegistration()
        {
        
        System.Console.WriteLine("Enter Your Name:");
        string name2=Console.ReadLine();

        System.Console.WriteLine("Enter Father Name: ");
        string fatherName2=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Date of Birth in DD/MM/YYYY:");
        DateTime dateofBirth2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        System.Console.WriteLine("Enter Your gender:");
        Gender gender2=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Enter your phone number:");
        long phoneNumber2=long.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter your Mail Id:");
        string mailId2=Console.ReadLine();
        
        System.Console.WriteLine("Enter your Physics Mark:");
        int physics2=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter your Chemistry Mark:");
        int chemistry2=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter your Mathematics Mark:");
        int maths2=int.Parse(Console.ReadLine());

        StudentDetails student=new StudentDetails(name2,fatherName2,dateofBirth2,gender2,phoneNumber2,mailId2,physics2,chemistry2,maths2);
        StudentList.Add(student);
        System.Console.WriteLine($"Student Added Succesfully and StudentID-{student.RegisterNumber}");

       }
       public static void Login()
        {
          System.Console.WriteLine("Enter Your RegisterNumber:");
          string registerNumber=Console.ReadLine().ToUpper();
          foreach (StudentDetails student in StudentList)
          {
            if(student.RegisterNumber==registerNumber)     
            {
            System.Console.WriteLine("Login Succesfully!!!");
            currentStudent=student;
            SubMenu();
            }
          }    
        }
        public static void DepartmentDetails()
        {
            System.Console.WriteLine(" Your Department Name :");
            DepartmentName departmentName=Enum.Parse<DepartmentName>(Console.ReadLine(),true);
            System.Console.WriteLine("Number of Seats Available :");
            int numberOfSeats=int.Parse(Console.ReadLine()); 

            DepartmentDetails department=new DepartmentDetails(departmentName,numberOfSeats);
            DepartmentList.Add(department);
            System.Console.WriteLine(department.DepartmentId);
        }
        public static void SubMenu()
                    {
                        
                        string choice="yes";
                        do
                        {
                            System.Console.WriteLine("SubMenu 1.Check Eligibility 2.Show Details 3. Take Admission 4. Cancel Admission 5.Exit");
                            int option=int.Parse(Console.ReadLine());
                                switch (option)
                                { 
                                    case 1:
                                      {
                                        System.Console.WriteLine("Check Eligibility For Admission ");
                                        if(currentStudent.CheckEligibility(75.00))
                                        System.Console.WriteLine("Student is Eligible For Admission");
                                        else
                                        System.Console.WriteLine("Student is not Eligible");
                                        break;
                                    }
                                    case 2:
                                    {
                                        System.Console.WriteLine("Show Student  Detail");
                                        
                                        currentStudent.ShowDetails();
                                        break;
                                    }    
                                    case 3:
                                    {
                                        System.Console.WriteLine("Take admission");
                                        TakeAdmission();
                                    
                                        break;
                                    }
                                    case 4:
                                    {
                                        System.Console.WriteLine("Cancel Admission");
                                        CancelAdmission();
                                        break;
                                    }
                                    case 5:   
                                    {
                                        System.Console.WriteLine("Admission Details");
                                        currentAdmission.ShowAdmissionDetails();

                                        break;
                                    }
                                    case 6:
                                    {
                                        System.Console.WriteLine("Exit Submenu");
                                        
                                        break;
                                    }
                                    default:
                                        break;
                                    
                                }
                            }while(choice=="yes");                  
    }
    public static void StudentData()
    {
        StudentList.Add(new StudentDetails("Ravichandran E","Ettapparajan",new DateTime(11/11/1999),Gender.Male,616262,"jaja",95,95,95));
        StudentList.Add(new StudentDetails("Baskaran S","sethurajan",new DateTime(11/11/1999),Gender.Male,726272,"ggags",95,95,95));
    }
    public static void DepartmentData()
    {
        DepartmentList.Add(new DepartmentDetails(DepartmentName.EEE,29));
        DepartmentList.Add(new DepartmentDetails(DepartmentName.CSE,29));
        DepartmentList.Add(new DepartmentDetails(DepartmentName.ECE,30));
        DepartmentList.Add(new DepartmentDetails(DepartmentName.MECH,30));
    }
    public static void AdmissionData()
    {
        AdmissionList.Add(new AdmissionDetail("SF3001","DID101",new DateTime(11/05/2022),AdmissionStatus.Booked));
        AdmissionList.Add(new AdmissionDetail("SF3002","DID102",new DateTime(12/05/2022),AdmissionStatus.Booked));
    }
    public static void TakeAdmission()
    {
       foreach(DepartmentDetails department in DepartmentList)
       {
            System.Console.WriteLine($"Department Id:{department.DepartmentId} Department Name:{department.Departments}  Number of seats:{department.NumberOfSeats}");
       }
        System.Console.WriteLine("Enter the department id:");
        string departmentId1=Console.ReadLine().ToUpper();
        foreach(DepartmentDetails department in DepartmentList)
        {
            if(departmentId1==department.DepartmentId)
            {
                
                
               if(department.NumberOfSeats>=1)
               {
                bool eligibility=currentStudent.CheckEligibility(75.0);
                if(eligibility)
                {
         System.Console.WriteLine("Student eligible");
                 bool admit=true;
    foreach(AdmissionDetail admission in AdmissionList)
                  {
    if(admission.StudentID==currentStudent.RegisterNumber)
                        {
                                     if(admission.AdmissionStatus==AdmissionStatus.Booked)
                            {
                                System.Console.WriteLine("You are already booked");
                                admit=false;
                            }
}
}
 if(admit)
{
    department.NumberOfSeats-=1;
    AdmissionDetail admission2=new AdmissionDetail(currentStudent.RegisterNumber,department.DepartmentId,DateTime.Now,AdmissionStatus.Booked);
    AdmissionList.Add(admission2);
    System.Console.WriteLine("Admitted...Successfully");
    System.Console.WriteLine("Your admission Id:"+admission2.AdmissionID);
    }
    }
    }
    }
    }
                
    }
 public static void CancelAdmission()
{
foreach(AdmissionDetail admission1 in AdmissionList)
                {
if(admission1.StudentID==currentStudent.RegisterNumber)
                    {
        System.Console.WriteLine(admission1.AdmissionID,admission1.StudentID,admission1.DepartmentId,admission1.AdmissionDate,admission1.AdmissionStatus);
        if(admission1.AdmissionStatus==AdmissionStatus.Booked)
                        {
         admission1.AdmissionStatus=AdmissionStatus.Cancelled;
            foreach (DepartmentDetails department in DepartmentList)
{
    if(department.DepartmentId==admission1.DepartmentId)
            {
 department.NumberOfSeats++;
        System.Console.WriteLine("Seat cancelled successfully");
 }
    }
     }
 }
 }
 }


 }
}
    
           
        
        
    
    




 