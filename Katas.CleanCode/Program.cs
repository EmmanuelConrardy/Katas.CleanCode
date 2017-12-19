using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our great promotion calculator, press any key");
            Console.ReadKey();

            var arts = new List<Basket>
            {
                new Basket
                {
                    nba = 1,
                    p = 10,
                    d = 1,
                },
                 new Basket
                {
                    nba = 4,
                    p = 30,
                    d = 1,
                },
            }
        }

        public class Basket
        {
            public int nba;
            public double p;
            public int d;

        }
    }
}
