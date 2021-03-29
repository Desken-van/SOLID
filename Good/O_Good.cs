using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
     class O_Good
    {
        class Director
        {
            public string Name { get; set; }

            public Director(string name)
            {
                this.Name = name;
            }

            public void EmployWorker(IEmploy worker)
            {
                worker.Employ();
            }
        }
        interface IEmploy
        {
            void Employ();
        }
        class Lawyer : IEmploy
        {
            public void Employ()
            {
                Console.WriteLine("Юрист принят на работу");
            }
        }
        class Economist : IEmploy
        {
            public void Employ()
            {
                Console.WriteLine("Экономист принят на работу");
            }
        }
        class Manager : IEmploy
        {
            public void Employ()
            {
                Console.WriteLine("Менеджер принят на работу");
            }
        }
        //static void Main(string[] args)
        //{
            //Director sam = new Director("Sam");
            //sam.EmployWorker(new Lawyer());
            //Console.WriteLine();
            //sam.EmployWorker(new Economist());
            //Console.WriteLine();
            //sam.EmployWorker(new Manager());
            //Console.WriteLine();
            //Console.ReadKey();
        //}
    }
}
