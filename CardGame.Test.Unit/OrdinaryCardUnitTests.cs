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
        public void Constructor_SetNumberTo5_NumberIsCorrect()
        {
            var uut = new OrdinaryCard(new RedColor(), 5);
            Assert.That(uut.Number, Is.EqualTo(5));
        }
    }
}
