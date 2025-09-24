using System;
using NUnit.Framework;

namespace Vehicle_Inheritance
{
    [TestFixture()]
    public class TrunkTest
    {
        [Test()]
        public void PayloadPropertyTest()
        {
            Trunk oneTrunk = new Trunk(4, 150, 60);

            Assert.AreEqual(oneTrunk.Payload, 60);
        }

        [Test()]
        public void EfficiencyMethodTest()
        {
            Trunk oneTrunk = new Trunk(4, 150, 60);
            double finalEff = oneTrunk.Efficiency();

            Assert.AreEqual(finalEff, 0.28571428571);
        }
    }
}