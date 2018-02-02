using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public interface IPlayer
    {
        List<ICard> CardsOnHand { get; set; }
        string Name { get; }
    }
}
