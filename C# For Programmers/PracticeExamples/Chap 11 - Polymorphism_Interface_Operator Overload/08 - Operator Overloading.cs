/* 
 */

using System;

namespace Chap_11_Operator_Overload
{

   /***** Test Application *****/
   public class ComplexTest
   {
      public static void Main()
      {
         /* Declare 2 variables to store complex nb to be entered by user */
         ComplexNumber x, y;

         /* Prompt the user to enter the first complex numbers */
         Console.WriteLine("Enter the real part of complex number x: ");
         double realPart = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter the imaginary part of complex number x: ");
         double imaginaryPart = Convert.ToDouble(Console.ReadLine());
         x = new ComplexNumber(realPart, imaginaryPart);

         /* Prompt the user to enter the second complex numbers */
         Console.WriteLine("Enter the real part of complex number y: ");
         realPart = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter the imaginary part of complex number y: ");
         imaginaryPart = Convert.ToDouble(Console.ReadLine());
         y = new ComplexNumber(realPart, imaginaryPart);

         /* Display results of calculations with x and y */
         Console.WriteLine();
         Console.WriteLine("{0} + {1} = {2}", x , y , x + y);
         Console.WriteLine("{0} - {1} = {2}", x , y , x - y);
         Console.WriteLine("{0} * {1} = {2}", x , y , x * y);

         Console.ReadLine();

      }//end method Main

   }//end class ComplexTest

   /***** Class *****/
   public class ComplexNumber
   {
      /*** Instance variable ***/
      private double real;
      private double imaginary;

      /*** Constructor ***/
      public ComplexNumber(double real, double imaginary)
      {
         this.real = real;
         this.imaginary = imaginary;
      }//end constructor ComplexNumber

      /*** Properties ***/
      public double Real
      {
         get { return real; }
      }//end property Real

      public double Imaginary
      {
         get { return imaginary; }
      }//end property Imaginary

      /*** Methods ***/
      public override string ToString()
      {
         return string.Format("({0} {1} {2}i)",
            Real, ( (Imaginary < 0) ? "-" : "+" ),  Math.Abs(Imaginary) );
      }//end method ToString

      /*** Operator Overloading ***/
      // Overload the addition operator
      public static ComplexNumber operator+(ComplexNumber x, ComplexNumber y)
      {
         return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
      }//end operator +

      public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
      {
         return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
      }//end operator -

      public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
      {
         return new ComplexNumber(
            x.Real * y.Real - x.Imaginary * y.Imaginary ,
            x.Real * y.Imaginary + y.Real * x.Imaginary);
      }//end operator *

   }//end class ComplexNumber

}//end namespace Chap_11_Operator_Overload