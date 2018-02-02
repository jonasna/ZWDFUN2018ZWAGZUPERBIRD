using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public struct BlueColor : IColor
    {
        public int Multipler => 2;
        public override string ToString()
        {
            return "Blue";
        }
    }
}
