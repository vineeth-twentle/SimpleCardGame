using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCards.BusinessEntities
{
    // This is a master class of Card, has all the basic properties of a card.
    public class Card<T,L>
    {
        public T Face { get; set; }
        public L Value { get; set; }
    }
}
