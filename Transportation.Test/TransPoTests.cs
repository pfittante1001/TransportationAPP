using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Test
{
    [TestFixture]
    class TransPoTests
    {
        [Test]
        public void GetMake()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //Action
            testTranspo.GetMake = "Ford";
            string response = testTranspo.GetMake;

            //Assert
            Assert.That(response, Is.EqualTo("Ford"));

        }

        [Test]
        public void GetModel()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //Action
            testTranspo.GetModel = "Bronco";
            string response = testTranspo.GetModel;

            //Assert
            Assert.That(response, Is.EqualTo("Bronco"));

        }
        [Test]
        public void GetYear()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //Action
            testTranspo.GetYear = "1965";
            string response = testTranspo.GetYear;

            //Assert
            Assert.That(response, Is.EqualTo("1965"));

        }

        [Test]
        public void GetNumWheels()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //Action
            testTranspo.GetNumWheels = "4";
            string response = testTranspo.GetNumWheels;

            //Assert
            Assert.That(response, Is.EqualTo("4"));

        }
        [Test]
        public void GetColor()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //Action
            testTranspo.GetColor = "Red";
            string response = testTranspo.GetColor;

            //Assert
            Assert.That(response, Is.EqualTo("Red"));

        }
        [Test]
        public void GetEngineSize()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //Action
            testTranspo.GetEngineSize = "351";
            string response = testTranspo.GetEngineSize;

            //Assert
            Assert.That(response, Is.EqualTo("351"));

        }
        [Test]
        public void GetMPH()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //Action
            int response = testTranspo.GetMPH(55);

            //Assert
            Assert.That(response, Is.EqualTo(55));

        }
        [Test]
        public void GetMPG()
        {
            //arrange
            TransPo testTranspo = new TransPo();

            //Action
            int response = testTranspo.GetMPG(55, 11);

            //Assert
            Assert.That(response, Is.EqualTo(605));

        }

        [Test]
        public void GetWear()
        {
            //Arrange
            TransPo testTranspo = new TransPo();

            //Action
            string response = testTranspo.GetWear(0, 0, 0);

            //Assert

            Assert.That(response, Is.EqualTo("Invalid Entry"));
        }
        [Test]
        public void GetWear_if_miles_div_heat_is_Lessthan_50_percent_tread_return_UnSafe()
        {
            //Arrange
            TransPo testTranspo = new TransPo();

            //Action
            string response = testTranspo.GetWear(20, 85, 32);

            //Assert

            Assert.That(response, Is.EqualTo("UnSafe"));
        }

        [Test]
        public void GetWear_if_miles_div_heat_is_Greaterthan_50_percent_tread_return_safe()
        {
            //Arrange
            TransPo testTranspo = new TransPo();

            //Action
            string response = testTranspo.GetWear(1500, 85, 32);

            //Assert

            Assert.That(response, Is.EqualTo("Safe"));
        }
    }
}
