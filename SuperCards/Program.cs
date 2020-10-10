using SuperCards.BusinessLogic;

namespace SuperCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the object of game for simplecard type.
            SimpleCardGame simpleCardGame = new SimpleCardGame();
            simpleCardGame.Start();
        }
    }
}
