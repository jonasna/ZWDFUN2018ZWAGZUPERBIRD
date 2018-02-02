using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class OrdinaryWin : IWin
    {
        public IPlayer GetWinner(List<IPlayer> players)
        {
            IPlayer winner = null;
            int score = 0;

            foreach (var player in players)
            {
                var cards = player.ShowHand();

                int sumOfCards = 0;

                foreach (var card in cards)
                {
                    sumOfCards += card.Value;
                }

                if (sumOfCards > score)
                {
                    winner = player;
                    score = sumOfCards;
                }                   
            }

            return winner;
        }
    }
}
