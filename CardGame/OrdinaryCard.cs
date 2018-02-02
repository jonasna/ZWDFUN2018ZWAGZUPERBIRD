using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class OrdinaryCard : ICard
    { 
        public OrdinaryCard(IColor color, int number)
        {
            Color = color;
            Number = (number > 0 && number < 9) ? number : 1;
        }

        public int Value => Color.Multipler * Number;
        public int Number { get; }
        public IColor Color { get; }

        public override string ToString()
        {
            return Color + " " + Number;
        }
    }
}
