using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public struct YellowColor : IColor
    {
        public int Multipler => 4;
        public override string ToString()
        {
            return "Yellow";
        }
    }
}
