using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moore_s_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = Math.Log(100, 2) * 1.5 * 12;
            y = Math.Log(100, 2) * 1.5;

            Console.WriteLine("numarul de luni ca puterea de calcul sa se mareasca de 100 de ori la acelasi pret este");
            Console.WriteLine(Math.Round(x, 3));
            Console.WriteLine("in ani: ");
            Console.WriteLine(Math.Round(y, 3));

            Console.WriteLine("In continuare vom calcula numarul de luni/ani pentru ca puterea de calcul sa se maresca de un numar arbitrar de ori.");
            Console.WriteLine("Introduceti un numar n");
            double n = double.Parse(Console.ReadLine());

            x = Math.Log(n, 2) * 1.5 * 12;
            y = Math.Log(n, 2) * 1.5;

            Console.WriteLine("numarul de luni ca puterea de calcul sa se mareasca de {0} de ori la acelasi pret este", n);
            Console.WriteLine(Math.Round(x, 3));
            Console.WriteLine("in ani: ");
            Console.WriteLine(Math.Round(y, 3));
        }
    }
}
