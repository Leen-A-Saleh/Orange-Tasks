using System;
using System.Collections.Generic;
using System.Text;

namespace stdManagement_test.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Courses> enrolled { get; set; }

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.enrolled = new List<Courses>();
        }

        public bool enrollCourse(Courses course)
        {
            if (enrolled.Contains(course)) return false;
            enrolled.Add(course);
            return true;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Courses: {string.Join(",", enrolled)}";
        }


    }
    
}
