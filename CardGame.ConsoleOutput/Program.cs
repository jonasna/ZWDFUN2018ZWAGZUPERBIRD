using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ConsoleOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new OrdinaryPlayer("SwagBoy");
            var playerTwo = new OrdinaryPlayer("DopeBoy");

            var game = new Game(3, new OrdinaryWin());

            game.AddPlayer(playerOne);
            game.AddPlayer(playerTwo);

            game.Start();

        }
    }
}
