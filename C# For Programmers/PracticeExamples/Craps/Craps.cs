using System;

public class Craps
{
   private Random randomNumbers = new Random();

   // Enum with constants that represent the game status
   private enum Status { CONTINUE, WON, LOST }

   // Enum with constants that represent common rolls of the dice
   private enum DiceNames
   {
      // Loosing combination
      SNAKE_EYES = 2,
      TREY = 3,
      BOX_CARS = 12,
      // Wining combination
      SEVEN = 7,
      YO_LEVEN = 11
   }

   public void Play()
   {
      Status gameStatus = Status.CONTINUE;
      int myPoint = 0;

      int sumOfDice = RollDice();

      switch((DiceNames) sumOfDice)
      {
         case DiceNames.SEVEN:
         case DiceNames.YO_LEVEN:
            gameStatus = Status.WON;
            break;
         case DiceNames.SNAKE_EYES:
         case DiceNames.TREY:
         case DiceNames.BOX_CARS:
            gameStatus = Status.LOST;
            break;
         default:
            gameStatus = Status.CONTINUE;
            myPoint = sumOfDice;
            break;
      }// end switch

      while (gameStatus == Status.CONTINUE)
      {
         sumOfDice = RollDice();

         if (sumOfDice == myPoint)
         { gameStatus = Status.WON; }
         else if ( (DiceNames) sumOfDice == DiceNames.SEVEN)
         { gameStatus = Status.LOST; }
         else
         {  gameStatus = Status.CONTINUE; }
      }// end while

      /* Display won or lost message */
      if (gameStatus == Status.WON)
         Console.WriteLine("Player wins");
      else
         Console.WriteLine("Player loses");

   }// end method Play

   private int RollDice()
   {
      int die1 = randomNumbers.Next(1, 7);
      int die2 = randomNumbers.Next(1, 7);

      int sum = die1 + die2;

      Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);

      return sum;
   }// end method RollDice
}
