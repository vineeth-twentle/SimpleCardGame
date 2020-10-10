using SuperCards.BusinessEntities;
using SuperCards.Extensions;
using SuperCards.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SuperCards.Constants.SimpleCardConstants;

namespace SuperCards.BusinessLogic
{
    //This class has implentation of functions specific to the simplecard properties and gameplay.
    public class SimpleCardDeckOperations : IDeckOperations<SimpleCard>
    {
        private Stack<SimpleCard> _cardDeck;
        public SimpleCardDeckOperations()
        {
            _cardDeck = new Stack<SimpleCard>();
            CreateCardDeck();
            Shuffle();
        }

        //This implementation creates a new card deck
        public void CreateCardDeck()
        {
            foreach (Suit suitName in Enum.GetValues(typeof(Suit)))
            {
                foreach (CardNumber cardNumber in Enum.GetValues(typeof(CardNumber)))
                {
                    _cardDeck.Push(new SimpleCard() { Face = suitName, Value = cardNumber });
                }
            }
        }


        //This implements pops the top card from the card deck.
        public SimpleCard GetTopCard()
        {
            if (_cardDeck.Count == 0)
            {
                throw new Exception("No cards left to Play, please restart the game!");
            }
            return _cardDeck.Pop();
        }

        //This implements shuffles the card deck using the shuffle extension.
        public void Shuffle()
        {
            if (_cardDeck.Count == 0)
            {
                throw new Exception("No cards left to shuffle, please restart the game!");
            }
            _cardDeck = _cardDeck.Shuffle();
        }

        // This function returns the number of items in the deck.
        public int GetDeckCount()
        {
            return _cardDeck.Count;
        }

        //This implementaion empties the deck.
        public void ClearDeck()
        {
            _cardDeck.Clear();
        }
    }
}
