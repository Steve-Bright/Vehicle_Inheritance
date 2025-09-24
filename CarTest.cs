using System;
using NUnit.Framework;

namespace Vehicle_Inheritance
{
    [TestFixture()]
    public class CarTest
    {
        [Test()]
        public void PassengerLoadTest()
        {
            Car carOne = new Car(4, 100.0);
            Assert.AreEqual(carOne.PassengerLoad, 4);
        }
    }
}