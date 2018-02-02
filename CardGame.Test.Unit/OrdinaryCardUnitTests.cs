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

        public struct Format
        {
            public IColor _color;
            public string _name;

        }

        private static Format[] CardPrintCases =
        {
            new Format(){_color = new RedColor(), _name = "Red"},
            new Format(){_color = new BlueColor(), _name = "Blue"},
            new Format(){_color = new GreenColor(), _name = "Green"},
            new Format(){_color = new YellowColor(), _name = "Yellow"},
        };

        [TestCaseSource(nameof(CardPrintCases))]
        public void ToString_AllColors_FormatIsCorrect(Format format)
        {
            var uut = new OrdinaryCard(format._color, 5);
            Assert.That(uut.ToString(), Is.EqualTo(format._name + " " + 5));
        }

        [Test]
        public void GetValue_RedCardFive_ReturnIs5()
        {
            var uut = new OrdinaryCard(new RedColor(), 5);
            Assert.That(uut.Value, Is.EqualTo(5));
        }

        [Test]
        public void GetValue_BlueCardFive_ReturnIs10()
        {
            var uut = new OrdinaryCard(new BlueColor(), 5);
            Assert.That(uut.Value, Is.EqualTo(10));
        }

        [Test]
        public void GetValue_GreenCardFive_ReturnIs15()
        {
            var uut = new OrdinaryCard(new GreenColor(), 5);
            Assert.That(uut.Value, Is.EqualTo(15));
        }

        [Test]
        public void GetValue_YellowCardFive_ReturnIs20()
        {
            var uut = new OrdinaryCard(new YellowColor(), 5);
            Assert.That(uut.Value, Is.EqualTo(20));
        }
    }
}
