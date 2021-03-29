using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    class L_Good
    {
        class Worker
        {
            public int Salary { get; protected set; }
            public virtual int TakeSalary(int money)
            {
                //Предусловие (также Инварианта)
                if (money < 0)
                    throw new Exception("Зарплата не может быть меньше 0");

                this.Salary = money;

                //Постусловие
                if (this.Salary > 1500)
                {
                    this.Salary = this.Salary - ((this.Salary / 100) * 5);
                }
                return this.Salary;
            }
        }
        class TraineeWorker : Worker
        {
            public override int TakeSalary(int money)
            {
                //Предусловие (также Инварианта)
                if (money < 0)
                    throw new Exception("Зарплата не может быть меньше 0");
                this.Salary = money;
                //Постусловие
                if (this.Salary > 1500)
                {
                    this.Salary = this.Salary - ((this.Salary / 100) * 5);
                }
                return this.Salary;
            }
        }
        //static void Main(string[] args)
        //{
            //Worker worker = new Worker();
            //Console.WriteLine("Зарплата рабочего :  "+worker.TakeSalary(1800));
            //TraineeWorker trainee = new TraineeWorker();
            //Console.WriteLine("Зарплата Стажера :  " + trainee.TakeSalary(1800));
            //Console.ReadKey();
        //}
    }
}
