using NUnit.Framework;
using QuantityMeasurementProblem;

namespace QuantityMeasurementTest
{ 
    [TestFixture]
    public class Feet_Converstion
    {
        [Test]
        public void Inch_To_Feet_Fail()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(2, converstion.measure1(36));
        }
        [Test]
        public void Feet_To_Inch_Fail()
        {
            Converstion converstion1 = new Converstion();
            Assert.AreEqual(25, converstion1.measure(3));
        }
        [Test]
        public void Double_Feet_To_Ich()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(24, converstion.measure3(2));
        }
        [Test]
        public void Double_Inch_To_Feet_Fail()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(2, converstion.measure4(28));
        }
        [Test]
        public void Double_Inch_To_Feet()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(2, converstion.measure4(24));
        }
        
        // 0 feet return equal
        [Test]
        public void Zero_Feet_Retur_Equal()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(0, converstion.measure1(0));
        }
        // 0 inch return equal
        [Test]
        public void Zero_Inch_Return_Equal()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(0, converstion.measure4(0));
        }
        // 1 feet is equal to 12 inch
        [Test]
        public void Feet_To_Inch()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(12, converstion.measure(1));
        }
        // 12 inch is equal to 1 feet
        [Test]
        public void Inch_To_Feet()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(1, converstion.measure1(12));
        }

        // 1 inch != 1 feet
        [Test]
        public void Inch_Not_Equal_Feet()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(1, converstion.measure(1));
        }
        // 1 feet ! = 1 inch
        [Test]
        public void Feet_Not_Equal_To_Inch()
        {
            Converstion converstion = new Converstion();
            Assert.AreEqual(1, converstion.measure1(1));
        }
    }
}