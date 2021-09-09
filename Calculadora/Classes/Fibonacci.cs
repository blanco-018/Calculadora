using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Classes
{
    public class Fibonacci
    {
        public static int Fibon(int iteration) 
        {
            if (iteration < 0)
            {
                throw new Exception($"Introduce un numero positivo");

            } else _ = (iteration > 0); {

                if ((iteration == 1) || (iteration == 2)) {

                return 1;

            } else {

                return Fibon(iteration - 1) + Fibon(iteration - 2);
            }

            }
        }
    }
}
