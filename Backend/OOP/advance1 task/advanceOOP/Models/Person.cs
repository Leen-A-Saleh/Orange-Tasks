using System;
using System.Collections.Generic;
using System.Text;

namespace advanceOOP.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private int Age { get; set; }

        public Person(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name} - Age: {Age}";
        }
    }
}
