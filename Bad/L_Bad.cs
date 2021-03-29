using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Bad
{
    class L_Bad
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
                //Предусловие
                if (money < 0) // При удалении - нарушения правила Инвариантов
                    throw new Exception("Зарплата не может быть меньше 0");
                //Нарушение
                if (money > 2000)
                    throw new Exception("Стажер не мог заработать так много!!!!");
                this.Salary = money;
                //Постусловие отсутсвует
                return this.Salary;
            }
        }
        //static void Main(string[] args)
        //{
            //Worker worker = new Worker();
            //Console.WriteLine("Зарплата рабочего :  " + worker.TakeSalary(1800));
            //TraineeWorker trainee = new TraineeWorker();
            //Console.WriteLine("Зарплата Стажера :  " + trainee.TakeSalary(1800));
            //Console.ReadKey();
        //}
    }
}
