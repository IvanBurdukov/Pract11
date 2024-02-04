using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract11
{
    struct LinearEquation
    {
        public double k;
        public double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public double Root()
        {
            if (k == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконечно много решений.");
                    return double.NaN;
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решений.");
                    return double.NaN;
                }
            }
            else
            {
                double root = -b / k;
                Console.WriteLine("Корень уравнения: {0}", root);
                return root;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation equation = new LinearEquation(2, -4);
            Console.WriteLine("Решение уравнения 0 = {0}x + {1}:", equation.k, equation.b);
            equation.Root();
        }
    }
}