using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    internal class Task
    {
        class Vehicle
        {
            protected string Name;

            public void setName(string name)
            {
                Name = name;
            }
        }

        class Car : Vehicle
        {
            public void Display()
            {
                Console.WriteLine(Name);
            }
        }
    }
}
