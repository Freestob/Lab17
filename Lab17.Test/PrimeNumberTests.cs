using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab17;

namespace Lab17.Test
{
    [TestFixture]
    public class PrimeNumberTests
    {
        [Test]
        public void False_If_Number_Less_Than_Zero()
        {
            //Arrange
            var generator = new PrimeNumberValidator();

            //Act

            var result = generator.IsPrime(-1);
            Assert.IsFalse(result);
         
        }
        [Test]
        public void False_If_Number_Equal_To_Zero()
        {
            // Arrange
            var generator = new PrimeNumberValidator();

            //Act

            //Act

            var result = generator.IsPrime(0);
            Assert.IsFalse(result);

        }
        [Test]
        public void False_If_Number_Equal_To_One()
        {
            // Arrange
            var generator = new PrimeNumberValidator();


            //Act

            var result = generator.IsPrime(1);
            Assert.IsFalse(result);

        }
       [Test]
        public void False_If_Number_Is_Even()
        {
            var generator = new PrimeNumberValidator();


        //Act

        var result = generator.IsPrime(4);
        Assert.IsFalse(result);

        }
    [Test]
        public void False_If__Number_Is_Even_And_Greater_Than_Two()
        {
            var generator = new PrimeNumberValidator();


        //Act

        var result = generator.IsPrime(-1);
        Assert.IsFalse(result);

        }
        [Test]
        public void False_If__Number_Has_Decimal_Point_If_Divisible_By_Number_Other_Than_Itself()
        {
            var generator = new PrimeNumberValidator();


            //Act

            var result = generator.IsPrime(-1);
            Assert.IsFalse(result);

        }
    }
}

