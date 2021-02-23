using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Classes_Participation
{
    
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0.0;
            Address = new Address(); // =null;

        }

        public Student(string firstName, string lastName, string major, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = gpa;
        }

        public string CalculateDistinction()
        {
            string distinction;
            if (GPA >= 3.80)
            {
                distinction = "Summa Cum Laude";
            }
            else if (GPA >= 3.60)
            {
                distinction = "Magna Cum Laude";
            }
            else if (GPA > -3.40)
            {
                distinction = "Cum Laude";
            }
            else
            {
                distinction = "No special distinction";
            }

            return distinction;

        }

        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address = new Address(streetNumber, streetName, state, city, zipcode);
            // Address.StreetNumber=streetnumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {CalculateDistinction()}";
        }
    }
}

