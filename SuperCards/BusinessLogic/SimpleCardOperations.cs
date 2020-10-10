using SuperCards.BusinessEntities;
using SuperCards.Interfaces;
using System;

namespace SuperCards.BusinessLogic
{
    public class SimpleCardOperations : ICardOperations<SimpleCard>
    {
        //This implementation has the logic to display the required information of the passed card parameter.
        public void DisplayCard(SimpleCard card)
        {
            Console.WriteLine($"The card is {card.DisplayName}");
        }
    }
}
