/* RadioButtons can be group into logical units where only 1 button is checked at a time.
 * To do so, each logical unit needs to be a container (GroupBox or Panel) and the radio buttons can be added to a container to group them as a logical unit.
 *
 * In this exple, 2 logical units (2 GroupBoxes) are created and radio buttons are added to each of them.
 * The selection of radio buttons determines the type of user prompt (Message Box): what buttons are visible, what icon is displayed.
 * 
 * The program can read what button is pressed inside the user prompt and display it on a label.
 * 
 * NOTE: All radio buttons of a group have the same event handler. The parameter "sender" is used to know which radio button has triggered the event.
 * 
 */


using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class RadioButtonsTestForm : Form
   {
      /*** Instance variables: Store the user's choice of options (Enum type) ***/
      private MessageBoxIcon iconTypeEnum;         // Enum of all the type of icons that can be displayed in a message box
      private MessageBoxButtons buttonTypeEnum;    // Enum of all the type of buttons that can be visible in a message box

      /*** Constructor ***/
      public RadioButtonsTestForm()
      {
         InitializeComponent();
      }//end constructor

      /*** Event Handler ***/

      /* Event handler when the selection of checked radio button of the "Button Type" group box is changed  */
      private void buttonType_CheckedChanged(object sender, EventArgs e)
      {
         // sender is one of the radio button
         if (sender == okayButton)
            buttonTypeEnum = MessageBoxButtons.OK;
         else if(sender == okayCancelButton)
            buttonTypeEnum = MessageBoxButtons.OKCancel;
         else if (sender == abortRetryIgnoreButton)
            buttonTypeEnum = MessageBoxButtons.AbortRetryIgnore;
         else if (sender == yesNoCancelButton)
            buttonTypeEnum = MessageBoxButtons.YesNoCancel;
         else if (sender == yesNoButton)
            buttonTypeEnum = MessageBoxButtons.YesNo;
         else
            buttonTypeEnum = MessageBoxButtons.RetryCancel;
      }//end event buttonType_CheckedChanged

      /* Event handler when the selection of checked radio button of the "Icon Type" group box is changed  */
      private void iconType_CheckedChanged(object sender, EventArgs e)
      {
         // sender is one of the radio button
         if (sender == asteriskButton)
            iconTypeEnum = MessageBoxIcon.Asterisk;
         else if (sender == errorButton)
            iconTypeEnum = MessageBoxIcon.Error;
         else if (sender == exclamationButton)
            iconTypeEnum = MessageBoxIcon.Exclamation;
         else if (sender == handButton)
            iconTypeEnum = MessageBoxIcon.Hand;
         else if (sender == informationButton)
            iconTypeEnum = MessageBoxIcon.Information;
         else if (sender == questionButton)
            iconTypeEnum = MessageBoxIcon.Question;
         else if (sender == stopButton)
            iconTypeEnum = MessageBoxIcon.Stop;
         else
            iconTypeEnum = MessageBoxIcon.Warning;
      }//end event iconType_CheckedChanged

      /* Event handler when the Display button is clicked  */
      private void displayButton_Click(object sender, EventArgs e)
      {
         // "result" holds the return value of the message box (DialogResult type)
         DialogResult result = MessageBox.Show("This is your Message", "Custom Message", buttonTypeEnum, iconTypeEnum, 0, 0);

         switch (result)
         {
            case DialogResult.OK:
               displayLabel.Text = "Ok was pressed";
               break;

            case DialogResult.Cancel:
               displayLabel.Text = "Cancel was pressed";
               break;

            case DialogResult.Abort:
               displayLabel.Text = "Abort was pressed";
               break;

            case DialogResult.Retry:
               displayLabel.Text = "Retry was pressed";
               break;

            case DialogResult.Ignore:
               displayLabel.Text = "Ignore was pressed";
               break;

            case DialogResult.Yes:
               displayLabel.Text = "Yes was pressed";
               break;

            case DialogResult.No:
               displayLabel.Text = "No was pressed";
               break;

         }//end switch

      }//end event displayButton_Click

   }//end class RadioButtonsTestForm

}//end namespace Chap_13_GUI_1
