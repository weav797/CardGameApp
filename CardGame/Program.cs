using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Deck
    {
        public void CreateDeck()
        {

        }

        public virtual void ShuffleDeck()
        {

        }

        public abstract List<PlayingCard> DealCard();

        public virtual PlayingCard RequestCard()
        {

        }
    }

    public class PlayingCard
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum CardSuit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
}
