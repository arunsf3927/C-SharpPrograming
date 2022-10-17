using System;
namespace EmployeePayRoll;
using System.Collections.Generic;

    class Program
    {
        public static void Main(string[] args)
        {
             List<EmployeePayRoll> EmployeeList=new List<EmployeePayRoll>();
        System.Console.WriteLine("If you want to calculate the salary :");
        string willing = Console.ReadLine().ToLower();   
        while(willing=="yes")
        {
            System.Console.WriteLine("Enter the employee Id");
            object id =(Console.ReadLine());

            System.Console.WriteLine("Enter the employee name");
            string name =(Console.ReadLine());

             System.Console.WriteLine("Enter the employee role");
            string role =(Console.ReadLine());

            System.Console.WriteLine("Enter the work location:");
            Location location = Enum.Parse<Location>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter the employe team name");
            string teamname =(Console.ReadLine());

            System.Console.WriteLine("Enter the Doj :");
             DateTime doj = DateTime.ParseExact(Console.ReadLine(),"dd//MM//yyyy",null);

             EmployeePayRoll employee= new EmployeePayRoll(id,name,role,location,teamname,doj);
             EmployeeList.Add(employee);
             employee.CalculateSalary();
System.Console.WriteLine("Your employee name is :"+employee.Name+"\n Your Employee Role :"+employee.Role+"\n Location :"+employee.Location+"\"\n Your DOj"+employee.DOJ.ToString("dd//MM//yyyy")+"\nTeamName :"+employee.TeamName+"\n Salaray is :"+employee.CalculateSalary);
             System.Console.WriteLine("\n Employee Id :"+id+"\n Employee name"+name+"\n Employee role"+role+"\nEmployee location"+location+"\n Employee teeam name"+teamname+"\n Employee doj"+doj);

            
        }
        } 
        
    }


