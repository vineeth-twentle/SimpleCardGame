using SuperCards.Constants;

namespace SuperCards.BusinessEntities
{
    //This class inherits the master Card class and creates a class of simplecard type.
    public class SimpleCard:Card<SimpleCardConstants.Suit, SimpleCardConstants.CardNumber>
    {
        public string DisplayName { get { return $"{Face.ToString()}-{Value.ToString()}"; } }
    }
}
