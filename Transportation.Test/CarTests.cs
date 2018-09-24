using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class CarTests
    {
        [Test]
        public void CreateCar()
        {
            //Arrange
            Car testCar = new Car();

            //Action
            testCar.GetMake = "Ford";
            string response = testCar.GetMake;

            //Assert
            Assert.That(response, Is.EqualTo("Ford"));
        }
    }
}
