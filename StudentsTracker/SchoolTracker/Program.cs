using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolTracker
{
    class Program 
    {
        static void Main(string[] args)
        {

            var students = new List<Students>();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Students();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

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
        }

        static void Import()
        {
            var importedStudent = new Students("Stoil", 80, "birthday", "addres", 12345);
            Console.WriteLine(importedStudent.Name); 
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    class Students : Member
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;

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

    class Teacher : Member
    {
        public string Subject;
    }
}
