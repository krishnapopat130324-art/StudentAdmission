using System;

namespace StudentAdmission
{
    class Student
    {
        private int id;
        private string name;
        private string course;
        private double fees;

        public Student(int id, string name, string course, double fees)
        {
            this.id = id;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n------ Student Details ------");
            Console.WriteLine("Student ID : " + id);
            Console.WriteLine("Name       : " + name);
            Console.WriteLine("Course     : " + course);
            Console.WriteLine("Fees       : " + fees);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Student Admission Management System ======");

            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.Write("Enter Fees: ");
            double fees = Convert.ToDouble(Console.ReadLine());

            Student s1 = new Student(id, name, course, fees);

            s1.DisplayDetails();

            Console.WriteLine("\nAdmission Successful!");

            Console.ReadKey();
        }
    }
}