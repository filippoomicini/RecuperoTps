using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace recuperoTps
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MetodoSomma));
            Thread t2 = new Thread(new ThreadStart(Tabellina));
        }

        public void MetodoSomma()
        {
            int Add1 = 10;
            int Add2 = 1;
            int Somma = Add1 + Add2;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Somma: " + Somma);
            }
        }

        public void Tabellina()
        {
            int val = 70;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tabellina: " + val * i);
            }
        }
    }
}
