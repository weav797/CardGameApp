using System.Collections.Generic;

namespace CardGame
{
    public class GinRummyDeck : Deck
    {
        public GinRummyDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            for (int i = 0; i < 10; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        /* Can be improved later on since method repeats iteself. */
        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            foreach (var card in cardsToDiscard)
            {
                output.Add(DrawOneCard());
                discardPile.Add(card);
            }

            return output;
        }
    }
}
