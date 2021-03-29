using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Bad
{
    class S_Bad
    {
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
            public void Take()
            {
                Console.WriteLine("Книга выбрана");
                Console.WriteLine(BookName);
            }
            //static void Main(string[] args)
            //{
            //Reader reader = new Reader();
            //reader.BookName = "Steven King";
            //reader.Take();
            //Console.ReadKey();
            //}
        }
    }
}
