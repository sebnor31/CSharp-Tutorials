public class MaximumFinder
{
   public void DetermineMaximum()
   {
      // Prompt for and input three floating-point values
      System.Console.WriteLine("Enter 3 floating-point values:\n");
      double number1 = System.Convert.ToDouble( System.Console.ReadLine() );
      double number2 = System.Convert.ToDouble( System.Console.ReadLine() );
      double number3 = System.Convert.ToDouble( System.Console.ReadLine() );

      // Determine the maximum value
      double max = Maximum(number1, number2, number3);

      // Display maximum value
      System.Console.WriteLine("Maximum is: " + max);

   }// end method DetermineMaximum

   private double Maximum(double x, double y, double z)
   {
      double max;

      max = System.Math.Max(x, y);
      max = System.Math.Max(max, z);

      return max;
   }// end method Maximum

}// end class MaximumFinder 
