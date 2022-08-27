using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            double b = Convert.ToDouble(Console.ReadLine());

            Quadratic quadratic = new Quadratic(k, b);
            Console.WriteLine(quadratic.Root());
            Console.ReadKey();
        }
    }
}