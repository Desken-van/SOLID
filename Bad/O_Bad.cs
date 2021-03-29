using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Bad
{
    class O_Bad
    {
        class Director
        {
            public string Name { get; set; }
            public Director(string name)
            {
                this.Name = name;
            }
            public void Employ()
            {
                Console.WriteLine("На работу принят юрист");
            }
        }
        //static void Main(string[] args)
        //{
        //Director sam = new Director("Sam");
        //sam.Employ();
        //}
    }
}
