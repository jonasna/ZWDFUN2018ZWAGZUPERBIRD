using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class RedColor : IColor
    {
        public int Multipler => 1;
        public override string ToString()
        {
            return "Red";
        }
    }
}
