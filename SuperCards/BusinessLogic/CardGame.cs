using SuperCards.BusinessEntities;
using SuperCards.Extensions;
using SuperCards.Interfaces;
using System;
using System.Collections.Generic;
using static SuperCards.Constants.SimpleCardConstants;

namespace SuperCards.BusinessLogic
{
    public class SimpleCardGame: IGame
    {
        // This function has the logic to start and handle the game flow.
        public void Start()
        {
            int selectedOption;
            Console.WriteLine("Card Game Started!\n");
            SimpleCardDeckOperations simpleCardDeckOperations = new SimpleCardDeckOperations();
            SimpleCardOperations simpleCardOperations = new SimpleCardOperations();
            DisplayGameOptions();

            while (true)
            {
                try
                {
                    selectedOption = int.Parse(Console.ReadLine());
                    switch (selectedOption)
                    {
                        case (int)GameOptions.PLAY:
                            var topCard = simpleCardDeckOperations.GetTopCard();
                            Console.WriteLine(topCard.DisplayName);
                            Console.WriteLine($"Cards remaining in the deck - {simpleCardDeckOperations.GetDeckCount()}");
                            break;
                        case (int)GameOptions.RESTART:
                            simpleCardDeckOperations.ClearDeck();
                            Console.WriteLine("Restarting game!");
                            Console.Clear();
                            Start();
                            break;
                        case (int)GameOptions.SHUFFLE:
                            simpleCardDeckOperations.Shuffle();
                            Console.WriteLine("Card deck shuffled successfully!");
                            break;
                        case (int)GameOptions.EXIT:
                            simpleCardDeckOperations.ClearDeck();
                            Console.WriteLine("Thanks for playing the game!");
                            Environment.Exit(0);
                            return;
                        default:
                            Console.WriteLine("Please choose a game option from the list.");
                            DisplayGameOptions();
                            break;
                    }
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("Please enter only numbers!");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        //This function displays all the game options from the constants.
        public void DisplayGameOptions()
        {
            foreach (GameOptions gameOption in Enum.GetValues(typeof(GameOptions)))
            {
                Console.WriteLine($"{(int)gameOption}. {gameOption.GetDescription()}");
            }
        }
    }
}
