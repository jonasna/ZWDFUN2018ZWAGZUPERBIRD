using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CardGame.Test.Unit
{
    [TestFixture]
    public class OrdinaryCardTests
    {
        [Test]
        public void Constructor_NumberArgument5_NumberIsCorrect()
        {
            var uut = new OrdinaryCard(new RedColor(), 5);

            Assert.That(uut.Number, Is.EqualTo(5));
        }
    }
}
