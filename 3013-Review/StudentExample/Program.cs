using System;
using System.Collections.Generic;
using System.IO;
/// <summary>
/// @Author Zareen Anan Khan's Classwork
/// </summary>

namespace StudentExample
{
    class Program
    {
        private static IEnumerable<object> students;

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("studentdataRandom100Rows.csv");

            List<Student> students = new List<Student>();

            //Student s = new Student(5, "Joe", "Joe", "Blue");
            //Student s1 = new Student();
            //s1.FirstName = "Joe";
            //s1.LastName = "Joe";

            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                var pieces = line.Split(',');
                int id = (int)Convert.ToInt64(pieces[0]);

                Student currentStudent = new Student(Convert.ToInt64(pieces[0], pieces[1], pieces[2], pieces[3]));
                students.Add(currentStudent);

            }

            

            Console.ReadLine();
        }

        private static void PrintStudentsWithFavoriteColor(string color)
        {
            foreach (var student in students)
            {
                if (student.FavoriteColor.ToLower() == color.ToLower())
                {
                    Console.WriteLine(student.CreateFullName());
                }
            }

        }
        private static void PrintStudentsWithFavoriteColor(string v, object color)
        {
            throw new NotImplementedException();
        }
    }
}
