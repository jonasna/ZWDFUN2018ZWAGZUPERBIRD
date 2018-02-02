using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public interface ICard
    {
        int Value { get; }
        int Number { get; }
        IColor Color { get; }
    }
}
