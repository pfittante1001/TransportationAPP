using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class MotorCycleTests
    {
        [Test]
        public void CreateCycle()
        {
            //Arrange
           Cycle testCycle = new Cycle();

            //Action
            testCycle.GetMake = "BMW";
            string response = testCycle.GetMake;

            //Assert
            Assert.That(response, Is.EqualTo("BMW"));
        }

    }
}
