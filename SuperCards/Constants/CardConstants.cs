using System.ComponentModel;

namespace SuperCards.Constants
{
    //This class stores all the constants essential for a type of card.
    public static class SimpleCardConstants
    {
        public enum Suit
        {
            Spade,
            Heart,
            Club,
            Diamond,
        }

        public enum CardNumber
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }

        public enum GameOptions
        {
            [Description("Play A Card")]
            PLAY=1,
            [Description("Shuffle Cards")]
            SHUFFLE = 2,
            [Description("Restart Game")]
            RESTART = 3,
            [Description("Exit Game")]
            EXIT = 4

        }
    }
}
