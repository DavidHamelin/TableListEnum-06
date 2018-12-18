using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabEx06
{
    class Program
    {
        enum week { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche }

        static void Main(string[] args)
        {
            foreach (string allTheWeek in Enum.GetNames(typeof(week)))
            {
                Console.WriteLine(allTheWeek);
            }

            /*
            week lundi = week.Lundi;
            Console.WriteLine(lundi);
            week mardi = week.Mardi;
            Console.WriteLine(mardi);
            week mercredi = week.Mercredi;
            Console.WriteLine(mercredi);
            ... */
        }
    }
}

