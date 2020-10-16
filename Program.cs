using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
          
            Console.ReadKey();



        }
    }
}
