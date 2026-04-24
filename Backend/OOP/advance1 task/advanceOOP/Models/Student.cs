using System;
using System.Collections.Generic;
using System.Text;

namespace advanceOOP.Models
{
    internal class Student : Person
    {
        public double Mark {  get; set; }
        public Student(int id, string name, int age, double mark) : base(id, name, age)
        {
            this.Mark = mark;
        }
        public override string ToString()
        {
            return base.ToString() + $"Mark: {Mark}";
        }

        public int incAge(int age) 
        {
            return age++; 

        }



    }
}
