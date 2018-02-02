using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CardGame.Test.Unit
{
    [TestFixture]
    public class OrdinaryPlayerUnitTests
    {
        [Test]
        public void Constructor_SetNameJohn_NameIsJohn()
        {
            var uut = new OrdinaryPlayer("John");
            Assert.That(uut.Name, Is.EqualTo("John"));
        }

        [Test]
        public void Constructor_AbitraryName_CardsOnHandIsEmpty()
        {
            var uut = new OrdinaryPlayer("John");
            var hand = uut.ShowHand();
            Assert.That(hand.Count, Is.EqualTo(0));
        }

        [Test]
        public void ShowHand_Add3Cards_CardsOnHandIs3()
        {
            var uut = new OrdinaryPlayer("Sven");
            uut.ReceiveCard(new OrdinaryCard(new YellowColor(), 3));
            uut.ReceiveCard(new OrdinaryCard(new RedColor(), 3));
            uut.ReceiveCard(new OrdinaryCard(new BlueColor(), 3));
            Assert.That(uut.ShowHand().Count, Is.EqualTo(3));
        }
    }
}
