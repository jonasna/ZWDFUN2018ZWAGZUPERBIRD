using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class OrdinaryPlayer : IPlayer
    {
        private List<ICard> _cardsOnHands;

        public OrdinaryPlayer(string name)
        {
            Name = name;
            _cardsOnHands = new List<ICard>();
        }

        public void ReceiveCard(ICard card)
        {
            _cardsOnHands.Add(card);
        }

        public List<ICard> ShowHand()
        {
            var hand = new List<ICard>();

            foreach (var card in _cardsOnHands)
            {
                hand.Add(card);
            }

            return hand;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat($"{Name}: ");

            foreach (var card in _cardsOnHands)
            {
                sb.AppendFormat($"[{card}] ");
            }

            sb.AppendLine();

            return sb.ToString();
        }

        public string Name { get; }
    }
}
