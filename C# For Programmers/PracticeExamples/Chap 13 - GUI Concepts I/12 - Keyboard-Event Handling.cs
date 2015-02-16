/* This code reads the keys pressed by the user and displays them  */

using System;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class KeyDemoForm : Form
   {
      public KeyDemoForm()
      {
         InitializeComponent();
      }//end constructor

      private void KeyDemoForm_KeyPress(object sender, KeyPressEventArgs e)
      {
         charLabel.Text = "Key pressed: " + e.KeyChar;

      }//end event KeyDemoForm_KeyPress

      private void KeyDemoForm_KeyDown(object sender, KeyEventArgs e)
      {
         keyInfoLabel.Text =
            "Alt: " + (e.Alt ? "Yes" : "No") + "\n" +
            "Shift: " + (e.Shift ? "Yes" : "No") + "\n" +
            "Ctrl: " + (e.Control ? "Yes" : "No") + "\n" +
            "KeyCode: " + e.KeyCode + "\n" +
            "KeyData: " + e.KeyData + "\n" +
            "KeyValue: " + e.KeyValue;

      }//end event KeyDemoForm_KeyDown

      private void KeyDemoForm_KeyUp(object sender, KeyEventArgs e)
      {
         keyInfoLabel.Text = "";
         charLabel.Text = "";
      }//end event KeyDemoForm_KeyUp

   }//end class KeyDemoForm

}//end namespace
