/* Numeric Up Down control is used to put max and min values to user input. It also has a incrementation feature.
 * Some formatting are also available such as thousand separator, disabling direct value input but forcing use of incrementation.
 * 
 * This programs calculates the interest earned each year and displays it in a multiline text box.
 * 
 */


using System;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class InterestCalculatorForm : Form
   {
      /* Constructor */
      public InterestCalculatorForm()
      {
         InitializeComponent();
      }//end constructor

      /* Event Handler */
      private void calculateButton_Click(object sender, EventArgs e)
      {
         /* Declare variables to store user input */
         decimal principal;
         double rate;
         int year;
         decimal amount;
         string output;

         /* Retrieve User input */
         principal = Convert.ToDecimal(principalTextBox.Value);
         rate = Convert.ToDouble(interestTextBox.Value);
         year = Convert.ToInt32(yearUpDown.Value);

         /* Set output header */
         output = "Year\tAmount on Deposit\r\n";

         /* Calculate amount after each year and append to output */
         for (int yearCounter = 1; yearCounter <= year; yearCounter++)
         {
            amount = principal * ( (decimal) Math.Pow( (1 + rate / 100) , yearCounter) );
            output += string.Format("{0}\t{1:C}\r\n", yearCounter,amount);
         }//end for

         displayTextBox.Text = output;

      }//end event calculateButton_Click

   }//end class InterestCalculatorForm

}//end namespace Chap_13_GUI_1
