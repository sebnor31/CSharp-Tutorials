/* This UI accepts a password-type text input from the user, and then display it to a Label control when the button is clicked.
 * 
 * Upper control is a TextBox control where the user enter a string. Its properties has been changed with:
 *    Name = "inputPasswordTextBox"
 *    PasswordChar = *
 *    BorderStyle = Fixed3D
 * 
 * Middle control is a Label that display the input string when the button is clicked.
 *    Name = "displayPasswordLabel"
 *    BorderStyle = Fixed3D
 *    BackColor = GradientInactiveCaption
 *    
 * Lower control is a Button.
 *    Name = "displayPasswordButton_Click"
 *    Dock = Bottom
 *    Text = "Show Me"
 */

using System;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class LabelTextButton : Form
   {
      public LabelTextButton()
      {
         InitializeComponent();
      }

      /*** Event Handler when the button is clicked ***/
      private void displayPasswordButton_Click(object sender, EventArgs e)
      {
         /* Display the text that the user typed */
         displayPasswordLabel.Text = inputPasswordTextBox.Text;
      }//end method displayPasswordButton_Click

   }
}
