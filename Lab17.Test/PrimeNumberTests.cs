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
        public void Is_Number_Less_Than_Zero()
        {
            //Arrange
            var generator = new PrimeNumberValidator();

            //Act
            try
            {
                var result = generator.IsPrime(-1);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("The number must be greater than 1", ex.Message);
            }
        }
        [Test]
        public void Is_Number_Equal_To_Zero()
        {
            // Arrange
            var generator = new PrimeNumberValidator();

            //Act
            try
            {
                var result = generator.IsPrime(0);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("The number must be greater than 1", ex.Message);
            }
        }
        [Test]
        public void Is_Number_Equal_To_One()
        {
            // Arrange
            var generator = new PrimeNumberValidator();

            //Act
            try
            {
                var result = generator.IsPrime(1);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("The number must be greater than 1", ex.Message);
            }
        }
        [Test]
        public void Throw_Exception_If_Number_Is_Even()
        {
            var generator = new PrimeNumberValidator();

            try
            {
                var result = generator.IsEven(4);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("That number is even", ex.Message);
            }
        }
        [Test]
        public void Throw_Exception_If_Number_Is_Even_And_Greater_Than_Two()
        {
            var generator = new PrimeNumberValidator();

            try
            {
                var result = generator.IsEven(4);
            }
            catch(Exception ex)
            {
                Assert.AreEqual("That number is even", ex.Message);
            }
        }
    }
}
