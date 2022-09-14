using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace _5September
{
    public class Schooldata
    {
        static void Main(string[] args)
        {
             List<Student> students = new List<Student>();
            students.Add(new Student() { Name="Nilofar",Class="12 A2B"});
            students.Add(new Student() { Name = "Mehar", Class = "12 A2B" });
            students.Add(new Student() { Name = "Zamruth", Class = "11 A2C" });
            students.Add(new Student() { Name = "Varshini", Class = "12 A2C" });
            students.Add(new Student() { Name = "Sheriff", Class = "11 A3C" });
            students.Add(new Student() { Name = "Nazeera", Class = "12 A2B" });
            students.Add(new Student() { Name = "Amirbi", Class = "12 A2C" });
            students.Add(new Student() { Name = "Pandiyan", Class = "11 A2B" });
            students.Add(new Student() { Name = "Malliga", Class = "11 A2B" });

            List<Teacher> Teacherlist = new List<Teacher>();
            Teacherlist.Add(new Teacher() { Name = "Sahaya Mary", Class = "A2b", Subject = "Chemistry" });
            Teacherlist.Add(new Teacher() { Name = "Queeny", Class = "A2b", Subject = "Maths" });
            Teacherlist.Add(new Teacher() { Name = "Sivaprakasam", Class = "A2b", Subject = "Physics" });
            Teacherlist.Add(new Teacher() { Name = "Vasanthi", Class = "A2b", Subject = "Botany" });
            Teacherlist.Add(new Teacher() { Name = "Irudaya Mary", Class = "A2b", Subject = "Zoology" });
            Teacherlist.Add(new Teacher() { Name = "Shanthi", Class = "A2b", Subject = "English" });

            List<Subject> subjectList = new List<Subject>();
            subjectList.Add(new Subject() { Name = "English", SubjectId = "001", Class = "12 A2B" });
            subjectList.Add(new Subject() { Name = "Chemistry", SubjectId = "002", Class = "12 A2B" });
            subjectList.Add(new Subject() { Name = "Physics", SubjectId = "003", Class = "12 A2B" });
            subjectList.Add(new Subject() { Name = "Maths", SubjectId = "004", Class = "12 A2B" });
            subjectList.Add(new Subject() { Name = "Biology", SubjectId = "005", Class = "12 A2B" });
            Console.WriteLine("Students List");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            
            foreach(Student student in students)
            {
                Console.Write("Student Name: "+student.Name+" "+"Student Class : "+student.Class);
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Staff List");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (Teacher Teacher in Teacherlist)
            {
                Console.Write("Staff Name: " + Teacher.Name + " " + "Staff Class : " + Teacher.Class+" "+"Subject Handled : "+Teacher.Subject);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Subjects List");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (Subject sub in subjectList)
            {
                Console.Write("Subject Name: " + sub.Name + " " + "Class having the subject : " + sub.Class + " " + "Subject Id : " + sub.SubjectId);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
