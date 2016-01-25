using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskara
{
    public class Bhaskara
    {
        private double a;
        private double b;
        private double c;
        private double delta;
               
        public Bhaskara(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (a == 0)
            {
                throw new Ex_AZero();
            }
        }
       
        public double getX1()
        {

            this.delta = Delta.getDelta(a, b, c);

            double x1 = (-b + (Math.Sqrt(delta))) / (2 * a);

            return x1;
        }

        public double getX2()
        {
            this.delta = Delta.getDelta(a, b, c);

            double x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            return x2;
        }

        public double getDelta()
        {
            return this.delta;
        }

    }
}
