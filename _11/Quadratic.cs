using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    struct Quadratic
    {
        double k;
        double b;

        public Quadratic(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            double x = -b / k;
            if (k == 0)
                return "Ошибка.";
            else
                return $"x = {x}";
        }
    }
}
