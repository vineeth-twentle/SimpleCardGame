using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCards.Interfaces
{
    //This is the interface of all the operations on a card.
    public interface ICardOperations<T>
    {
        void DisplayCard(T card);
    }
}
