﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Intro.Models
{
    public class Student
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student()
        {
            FirstName = "";
            LastName = "";
        }

    }
}
