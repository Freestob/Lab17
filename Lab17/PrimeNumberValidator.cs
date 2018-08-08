using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class PrimeNumberValidator
    {
        public bool IsPrime(int number)
        {

            if (number <= 0 || number == 1)
            {
                return false;
            }
            if (number % 2 == 0 && number != 2)
            {
                return false;
            }
            else
            {
                var ceiling = Math.Sqrt(number);
                for (int i = 3; i <= ceiling; i += 2)
                {
                    if (number % i == 0)
                        throw new Exception("That number is not prime");
                }
                return true;
            }
        }
    }
}
