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
        [Test]
        public void GetTreadCycle_Override_miles_times_2_return_UnSafe()
        {
            //Arrange
            Cycle testCycle = new Cycle();

            //Action
            
            string response = testCycle.GetWear(20, 85, 32);

            //Assert
            Assert.That(response, Is.EqualTo("UnSafe"));
        }

        [Test]
        public void GetTreadCycle_Override_miles_times_2_return_Safe()
        {
            //Arrange
            Cycle testCycle = new Cycle();

            //Action

            string response = testCycle.GetWear(150, 85, 32);

            //Assert
            Assert.That(response, Is.EqualTo("UnSafe"));
        }


    }
}
