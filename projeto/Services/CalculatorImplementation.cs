using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Services;

    public class CalculatorImplementation
    {
        public double Somar (double n , double n2)
        {
            return n + n2;
        }
          public double multiplicar (double n , double n2)
        {
            return n * n2;
        }

          public double subtrair (double n , double n2)
        {
            return n - n2;
        }

          public double dividir (double n , double n2)
        {
            return n / n2;
        }
    }
