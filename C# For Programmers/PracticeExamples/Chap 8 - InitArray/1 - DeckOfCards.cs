using System;

public class DesckOfCardsTest
{
   public static void Main()
   {
      DeckOfCards myDeck = new DeckOfCards();   // Create an instanciated DeckOfCards object

      myDeck.Shuffle();    // Place cards in random order

      /* Print all 52 cards in the order in which they are dealt  */
      for (int i = 0; i < 13; i++)
      {
         Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}", 
            myDeck.DealCard(), myDeck.DealCard(), myDeck.DealCard(), myDeck.DealCard());
      }// end for

         Console.ReadLine();
   }// end Main
}// end class DesckOfCardsTest

public class DeckOfCards
{
   /* Declaration of instance variables */
   private Card[] deck;                      // array of Card objects
   private int currentCard;                  // index of next card to be dealt
   private Random randomNumbers;             // random number generator
   private const int NUMBER_OF_CARDS = 52;

   /* Constructor */
   public DeckOfCards()
   {
      string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", 
                         "Jack", "Queen", "King" };
      string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

      deck = new Card[NUMBER_OF_CARDS];   // Create array of Card objects
      currentCard = 0;                    // set first card dealt is deck[0]
      randomNumbers = new Random();       // Create a random number generator

      // Populate deck with Card objects
      for (int count = 0; count < deck.Length ; count++)
         deck[count] = new Card( faces[count % 13] , suits[count / 13] );

   }// end constructor DeckOfCards

   public void Shuffle()
   {
      /* After shuffling, dealing should start at deck[0] again */
      currentCard = 0;

      /* For each card, pick another random card, and swap them */
      for (int first = 0; first < NUMBER_OF_CARDS; first++)
      {
         // Select a random number between 0 and 51
         int second = randomNumbers.Next(NUMBER_OF_CARDS);

         // Swap current Card with andomly selected card
         Card temp = deck[first];
         deck[first] = deck[second];
         deck[second] = temp;

      }// end for

   }// end method Shuffle

   /* Deal one card */
   public Card DealCard()
   {
      if (currentCard < deck.Length)
         return deck[currentCard++];
      else
         return null;

   }// end method DealCard

}// end class DeckOfCards


public class Card 
{
   private string face;    // face of card ("Ace", "Deuce", "King", etc.)
   private string suit;    // suit of card ("Heart", "Spade", "Diamonds", "Clubs")

   public Card(string faceCard, string suitCard)
   {
      face = faceCard;
      suit = suitCard;
   }// end constructor Card

   public override string ToString()
   {
      return face + " of " + suit;
   }// end method ToString

}// end class Card

