using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Models
{
    internal class Company
    {

            public static string companyName = "Orange";
            //public static string companyName { get; set; }
            public Dictionary<int, string> employees = new Dictionary<int, string>();

            public bool addEmp(int id, string name)
            {
                if(employees.ContainsKey(id)) return false;
                employees[id] = name;
                return true;
        }

           override public string ToString()
           {
            var emp = employees.Select(e => $"{e.Key} - {e.Value}");
            return $"Company Name: {companyName}, Employees Name: \n{string.Join("\n", emp)}";
           }


    }
}
