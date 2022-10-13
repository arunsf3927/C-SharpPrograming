using System;
namespace MultipleInheritance;

class Program
{
public static void Main(string[] args)
{
    PersonalDetails person = new PersonalDetails("Ravi","chan",Gender.Male,1233);
    person.ShowDetails();
    StudentDetails student = new StudentDetails("52522","Ravi","chan",Gender.Male,1233,Department.ECE,"final");
    student.ShowStudent();
    student.GetMark(90,90,90);//added
    student.Calculation();//added
    student.ShowStudent();//added
    CustemerDetails custemer= new CustemerDetails("1233","ary","gagas",Gender.Male,1233);
    custemer.Recharge();
    custemer.Show();
        
}
}

