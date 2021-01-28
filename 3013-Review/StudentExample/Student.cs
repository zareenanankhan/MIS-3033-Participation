using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExample
{
    public class Student
    {
        private string MadeUpThingForExample;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }

        /// <summary> Default/Empty Constructor
       
        public Student()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }

        /// <summary> Overloaded constructor
        

        public Student(int id, string first, string last, string color)
        {
            ID = id;
            FirstName = first;
            LastName = last;
            FavoriteColor = color;

        }

        // in the event that a student has an ID but no other detail is known, after an ID is given to us OU asks us to fill in the rest of the details.
        public Student(int id)
        {
            ID = id;
            FirstName = string.Empty;
            LastName = string.Empty;
            FavoriteColor = string.Empty;

        }

        public string CreateFullName()
        {
            //return LastName+", "+FirstName

            return $"{LastName}, {FirstName}";
        }


    }


}
