using System;
using System.Collections.Generic;
using System.Text;

namespace stdManagement_test.Models
{
    internal class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }

        public Courses(int id , string name , string instructor)
        {
            this.Id = id;
            this.Name = name;
            this.Instructor = instructor;
        }

        public override string ToString()
        {
            return $"Course: {Name} - Instructor: {Instructor}";
        }
    }
}
