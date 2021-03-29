using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    class S_Good
    {
        interface IChoose
        {
            void Take(string BookName);
        }
        class ChooseBook : IChoose
        {
            public void Take(string BookName)
            {
                Console.WriteLine(BookName);
            }
        }
        class Reader
        {
            public string BookName { get; set; }
            public void GoToFirstShelf()
            {
                Console.WriteLine("Переход к первой полке");
            }
            public void GoToLastShelf()
            {
                Console.WriteLine("Переход к последней полке");
            }
            public void GoToShelf(int shelfNumber)
            {
                Console.WriteLine("Переход к полке {0}", shelfNumber);
            }
            public void Take(IChoose choose)
            {
                choose.Take(this.BookName);
            }
        }
        //static void Main(string[] args)
        //{
            //IChoose choose = new ChooseBook();
            //Reader reader = new Reader();
            //reader.BookName = "Steven King";
            //reader.Take(choose);
            //Console.ReadKey();
        //}
    }
}
