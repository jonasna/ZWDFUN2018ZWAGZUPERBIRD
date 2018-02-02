using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CardGame.Test.Unit
{
    [TestFixture]
    public class OrdinaryCardUnitTests
    {
        [Test]
        public void Constructor_SetNumberTo5_NumberIs5()
        {
            var uut = new OrdinaryCard(new RedColor(), 5);
            Assert.That(uut.Number, Is.EqualTo(5));
        }

        [Test]
        public void Constructor_SetNumberTo9_NumberIs1()
        {
            var uut = new OrdinaryCard(new RedColor(), 9);
            Assert.That(uut.Number, Is.EqualTo(1));
        }

        [Test]
        public void Constructor_SetNumberToNegative_NumberIs1()
        {
            var uut = new OrdinaryCard(new RedColor(), -500);
            Assert.That(uut.Number, Is.EqualTo(1));
        }

        [Test]
        public void ToString_RedCardFive_FormatIsCorrect()
        {
            var uut = new OrdinaryCard(new RedColor(), 5);
            Assert.That(uut.ToString(), Is.EqualTo("Red 5"));
        }

        [Test]
        public void GetValue_RedCardFive_ReturnIs5()
        {
            var uut = new OrdinaryCard(new RedColor(), 5);
            Assert.That(uut.Value, Is.EqualTo(5));
        }
    }
}
