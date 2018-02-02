using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public interface IPlayer
    {
        void ReceiveCard(ICard card);
        List<ICard> ShowHand();
        string Name { get; }
    }
}
