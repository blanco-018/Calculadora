using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Classes
{
    public class Factorial
    {
        public static int Fact(int n1)
        {
           
            if (n1 == 1)
            {
                return 1;
            }
            else 
            { 
                return n1 * Fact(n1 - 1);
            }

        }

    }
}
