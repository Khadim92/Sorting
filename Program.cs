using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Khadim", 18, 18));
            students.Add(new Student("Nasir", 19, 17));
            students.Add(new Student("Ahmad", 19, 15));
            List<Student> s = students.OrderByDescending(stu => stu.marks).ToList() ;
            foreach (Student stu in s)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2} ",stu.name,stu.marks,stu.age);
            }
        }
        class Student
        {
            public string name;
            public int age;
            public int marks;
            public Student(string name, int age, int marks)
            {
                this.name = name;
                this.age = age;
                this.marks = marks;
            }
        }
    }
}
