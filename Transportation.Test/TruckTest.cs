using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class TruckTest
    {
        [Test]
        public void CreateTruck()
        {
            //Arrange
            Truck testTruck = new Truck();

            //Action
            testTruck.GetMake = "Ford";
            string response = testTruck.GetMake;

            //Assert
            Assert.That(response, Is.EqualTo("Ford"));
        }
        
    }
}
