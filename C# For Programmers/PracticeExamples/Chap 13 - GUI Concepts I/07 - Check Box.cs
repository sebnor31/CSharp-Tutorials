/* The GUI is composed of 2 check boxes that can change the font style of a label.
 * The 2 font styles (Bold and Italic) can also be combined.
 * 
 * The operator ^ is a XOR that enables such combination.
 * An OR is not suitable as if the box is unchecked, the style needs to be removed which cannot be done through an OR but a XOR.
 * 
 * FontStyle is an enumerator that contains 5 different styles, including Bold and Italic.
 *  
 * */


using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class CheckBoxTestForm : Form
   {
      public CheckBoxTestForm()
      {
         InitializeComponent();
      }

      private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         outputLabel.Font = new Font(outputLabel.Font.Name, outputLabel.Font.Size, outputLabel.Font.Style ^ FontStyle.Bold);
      }

      private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         outputLabel.Font = new Font(outputLabel.Font.Name, outputLabel.Font.Size, outputLabel.Font.Style ^ FontStyle.Italic);
      }
   }
}
