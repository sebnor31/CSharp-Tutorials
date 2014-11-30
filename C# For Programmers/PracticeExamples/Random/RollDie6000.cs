using System;

class RollDie6000
{
   public static void Main()
   {
      Random die = new Random();
      int freq1 = 0; int freq2 = 0;
      int freq3 = 0; int freq4 = 0;
      int freq5 = 0; int freq6 = 0;

      for ( int roll = 1; roll <= 6000; roll++ )
      {
         switch ( die.Next(1, 7) )
         {
            case 1:
               freq1++;
               break;
            case 2:
               freq2++;
               break;
            case 3:
               freq3++;
               break;
            case 4:
               freq4++;
               break;
            case 5:
               freq5++;
               break;
            case 6:
               freq6++;
               break;
            default:
               continue;
         }// end switch

      }// end for

      Console.WriteLine("Face\tFrequency");
      Console.WriteLine("1\t{0}\n2\t{1}\n3\t{2}\n4\t{3}\n5\t{4}\n6\t{5}\n",
         freq1, freq2, freq3, freq4, freq5, freq6);
      Console.ReadLine();
   }// end method Main 

}// end class RollDie6000

