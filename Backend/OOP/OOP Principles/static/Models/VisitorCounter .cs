using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Models
{
    internal class VisitorCounter
    {
        public int Id { get; set; }
        static int Count = 0;
        public VisitorCounter(int id)
        {
            this.Id = id;
            Count++;
        }
        public override string ToString()
        {
            return $"Number of visitor: {Count}";
        }
    }
}
