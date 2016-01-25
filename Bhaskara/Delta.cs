using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskara
{
    class Delta
    {
        public static double getDelta(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta < 0)
            {
                throw new Ex_Delta_Negativo();
            }

            return delta;
        }
    }
}
