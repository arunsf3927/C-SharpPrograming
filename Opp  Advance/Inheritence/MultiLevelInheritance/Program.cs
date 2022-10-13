using System;
namespace MultiLevelInheritance;

class Program
{
public static void Main(string[] args)
{
    PersonalDetails person = new PersonalDetails("Ravi","chan",Gender.Male,1233);
    person.ShowDetails();
    StudentDetails student = new StudentDetails("52522","Ravi","chan",Gender.Male,1233,Department.ECE,"final");
    student.ShowStudent();
    student.GetMark(90,90,90);
    student.Calculation();
    student.ShowStudent();

    EmployementDetails employee = new EmployementDetails("SF1001","55555","Ravi","chan",Gender.Male,1233,Department.ECE);
    student.ShowStudent();
    employee.ShowEmployeMentDetails();//added
    student.GetMark(90,90,90);
    student.Calculation();
    student.ShowStudent();

    CustemerDetails custemer= new CustemerDetails("1233","ary","gagas",Gender.Male,1233);
    custemer.Recharge();
    custemer.Show();
        
}
}

