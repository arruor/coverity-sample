using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class NPathComplexity
    {
        static double Add(double num1, double num2)
        {
            if (Double.IsNaN(num1))
            {
                num1 = 0;
            }

            if (Double.IsNaN(num2))
            {
                num2 = 0;
            }

            return num1 + num2;
        }

        static double CheckNumber(double num)
        {
            if (Double.IsNaN(num))
            {
                return 0;
            }

            return num;
        }

        static double AddOptimized(double num1, double num2)
        {
            return CheckNumber(num1) + CheckNumber(num2);
        }
    }
}
