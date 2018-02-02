using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class OrdinaryDeck : IDeck
    {
        private List<ICard> _cards;
        public OrdinaryDeck()
        {
            _cards = new List<ICard>();

            IColor[] colors =
            {
                new RedColor(),
                new BlueColor(),
                new YellowColor(),
                new GreenColor()
            };

            for (int i = 1; i <= 8; i++)
            {
                foreach (var color in colors)
                {
                    _cards.Add(new OrdinaryCard(color, i));
                }
            }

            Shuffle();

        }
        public void DealCard(IPlayer player)
        {
            var card = _cards.First();
            _cards.Remove(card);
            player.ReceiveCard(card);
        }

        public void Shuffle()
        {
            var rnd = new Random();

            for (int i = _cards.Count-1; i >= 1 ; i--)
            {
                int randomIndex = rnd.Next(0, i + 1);

                var temp = _cards[i];
                _cards[i] = _cards[randomIndex];
                _cards[randomIndex] = temp;
            }

        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var card in _cards)
            {
                sb.AppendLine(card.ToString());
            }

            return sb.ToString();
        }
    }
}
