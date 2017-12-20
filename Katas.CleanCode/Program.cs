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
                    nba = 8,
                    p = 10,
                    d = 1,
                },
                 new Basket
                {
                    nba = 15,
                    p = 10,
                    d = 1,
                },
                 new Basket
                {
                    nba = 15,
                    p = 10,
                    d = 0,
                },
                 new Basket
                {
                    nba = -2,
                    p = 30,
                    d = 0,
                }
            };

            var c = new CalcPmManager();
            try
            {
                foreach (var b in arts)
                {
                    Console.WriteLine(b.ToString());
                    Console.WriteLine(c.Calc(b.nba, b.p, b.d));
                };
            }
            catch
            {
                Console.WriteLine("Error");
            }
            

            Console.WriteLine("Satisfy ?");
            Console.ReadKey();
        }

        public class Basket
        {
            public int nba;
            public double p;
            public int d;

            public override string ToString()
            {
                return $"nba:{nba} p:{p} d:{d}";
            }
        }
    }
}
