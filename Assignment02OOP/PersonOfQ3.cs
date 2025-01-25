using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    internal struct Person2  
    {

        public string Name { get; set; }
        public int Age { get; set;  }


        public Person2(string name,int age)
        {
            Name = name;
            Age=age;
        }

        public override string ToString()
        {
            return $"Person name is {Name} and his age is {Age} ";
        }
    }
}
