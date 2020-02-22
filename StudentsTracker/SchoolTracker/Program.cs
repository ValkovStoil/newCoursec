using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolTracker
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }
    class Program 
    {
        static List<Students> students = new List<Students>();

        static void Main(string[] args)
        {
            PayRoll payroll = new PayRoll();
            payroll.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Students();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    newStudent.School = (School)Util.Console.AskInt("School Name (type the corresponding number): \n\t 0: Hogwarts High \n\t 1: Harvard \n\t 2: MIT)\n\t");

                    newStudent.Birthday = Util.Console.Ask("Student Birthdaty ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

                    students.Add(newStudent);

                    Students.Count++;
                    Console.WriteLine($"Student Count: {Students.Count}");

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {

                    Console.WriteLine("Erro adding student, Please try again");
                }

                
            }
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
            }
            Exports();
        }

        static void Import()
        {
            var importedStudent = new Students("Stoil", 80, "birthday", "addres", 12345);
            Console.WriteLine(importedStudent.Name); 
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }
    }

    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

    }

    class Students : Member
    {
        static public int Count { get; set; } = 0;

        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }

        public Students()
        {

        }
        public Students(string name, int grade, string birthday, string addres, int phoneNumber)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = addres;
            Phone = phoneNumber;
        }
    }
}
