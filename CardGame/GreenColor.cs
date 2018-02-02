using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public struct GreenColor : IColor
    {
        public int Multipler => 3;
        public override string ToString()
        {
            return "Green";
        }
    }
}
