using System.Collections.Generic;

namespace SuperCards.Interfaces
{
    // This is the interface of all the operations on the deck.
    public interface IDeckOperations<T>
    {
        void CreateCardDeck();
        T GetTopCard();
        void Shuffle();
        void ClearDeck();
    }
}
