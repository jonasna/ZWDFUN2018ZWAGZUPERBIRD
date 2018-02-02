using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game
    {
        private List<IPlayer> _players;
        private IDeck _deck;
        private IWin _win;
        private int _cardsToDeal;

        public Game(int cardsToDeal, IWin winCondition)
        {
            _cardsToDeal = cardsToDeal < 6 && cardsToDeal > 0 ? cardsToDeal : 5;
            _players = new List<IPlayer>();
            _deck = new OrdinaryDeck();
            _win = winCondition;
        }
        public void AddPlayer(IPlayer player)
        {
            if (_players.Count * _cardsToDeal > 42)
                return;
            _players.Add(player);
        }
        
        public void Start()
        {
            if (_players.Count < 2)
            {
                Console.WriteLine("***\tNeed at least two people to start the game!\t***");
                return;
            }

            Console.WriteLine("***\tSTARTING THE GAME\t***");
            Console.WriteLine("**\tPlayers are:\t**");
            Console.WriteLine("\n");

            foreach (var player in _players)
            {
                Console.WriteLine(player.Name);
                for (int i = 0; i < _cardsToDeal; i++)
                {
                    _deck.DealCard(player);
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("***\tSTATUS FOR EACH PLAYER\t***");
            Console.WriteLine("\n");

            foreach (var player in _players)
            {
                Console.WriteLine(player.ToString());
            }

            var winner = _win.GetWinner(_players);

            int score = 0;

            foreach (var card in winner.ShowHand())
            {
                score += card.Value;
            }

            Console.WriteLine("\n");
            Console.WriteLine($"***\tAND THE WINNER WITH A SCORE OF {score} IS\t***");
            Console.WriteLine("\n");

            Console.WriteLine(winner);
            Console.WriteLine("\n");

            Console.WriteLine("***\tReady for a new players\t***");
            Console.WriteLine("\n");

            _players.Clear();
        }
    }
}
