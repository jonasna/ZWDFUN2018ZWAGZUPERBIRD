using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public interface IDeck
    {
        void DealCard(IPlayer player);
        void Shuffle(); // ??
    }
}
