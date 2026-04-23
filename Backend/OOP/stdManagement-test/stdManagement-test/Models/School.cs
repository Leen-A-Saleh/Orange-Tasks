using System;
using System.Collections.Generic;
using System.Text;

namespace stdManagement_test.Models
{
    internal class School
    {
        public List<Student> std {  get; set; }
        public List<Courses> courses {  get; set; }

        public School()
        {
            std = new List<Student>();
            courses = new List<Courses>();
        }

        public bool addStd(Student student)
        {
            if( std.Contains(student) ) return false;
            std.Add(student);
            return true;
        }

        public bool addCourse(Courses course)
        {
            if( courses.Contains(course)) return false;
            courses.Add(course);
            return true;
        }

        public override string ToString()
        {
            return $"Students in school {string.Join("\n",std)} - Courses in school {string.Join("\n", courses)}";
        }
    }
}
