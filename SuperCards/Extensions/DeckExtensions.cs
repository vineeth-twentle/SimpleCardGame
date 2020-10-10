using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperCards.Extensions
{
    //This extension shuffles the stack in random order.
    public static class DeckExtensions
    {
        static Random _randomNumber = new Random();
        public static Stack<T> Shuffle<T>(this Stack<T> cardStack)
        {
           return new Stack<T>(cardStack.OrderBy(card => _randomNumber.Next()));
        }
    }
}
