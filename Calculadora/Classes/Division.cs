using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Classes
{
    public class Division
    {
        public static double Div(double n1, double n2)
        {
            //guardar el resto en un array 

            double result = n1 / n2;
            double rest = n1 % n2;

            return result;
        }

    }
}
