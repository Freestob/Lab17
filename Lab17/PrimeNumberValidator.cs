using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class PrimeNumberValidator
    {
        public string IsPrime(int number)
        {

           if (number <= 0  || number == 1)
            {
                throw new Exception("The number must be greater than 1");
            }
           else
            {
                throw new NotImplementedException();
            }
        }
        public string IsEven(int number)
        {
            if (number %2 ==0 && number !=2)
            {
                throw new Exception("That number is even");
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
