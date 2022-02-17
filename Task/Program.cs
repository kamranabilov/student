using System;

namespace Student_17._02._22
{
    class Program
    {
        static void Main(string[] args)
        {          
            Student student = new Student("Lionel", "Messi", "P125", 90);
            Console.WriteLine(student.fullname());
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(student.Exam());
        }
    }
    class Student
    {       
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool Graduated;
        public Student(string name, string surname, string group, int point, bool isgraduated=false)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            Graduated = isgraduated;
        }
        public string fullname()
        {
            return Name + " " + Surname;
        }

        public string GetInfo()
        {
            string info = Name, Surname, Group, Point;
            if(Graduated)
            {
                return "mezun olub";
            }
            else
            {
                return info + "mezun olmadi";
            }
        } 
        public string Exam()
        {
            if (Point>80 && Point<100)
            {
                return "gire biler";
            }
            else
            {
                return "gire bilmez";
            }
        }
                    
    }
}
