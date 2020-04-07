using NUnit.Framework;
using QuantityMeasurementProblem;

namespace QuantityMeasurementTest
{
    [TestFixture]
    public class Feet_Converstion
    {
        [Test]
        public void Test1()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(24,converstion.measure(2));  
        }
        [Test]
        public void Test2()
        {
            Converstion converstion1 = new Converstion();
            Assert.AreEqual(25, converstion1.measure(3));
        }
        [Test]
        public void Test3()
        {
            Converstion converstion2 = new Converstion();
            Assert.AreEqual(48, converstion2.measure(4));
        }
    }
}