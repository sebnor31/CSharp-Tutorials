/* This code uses GroupBoxes and Panels controls. They are used to regroup controls into a container.
 * GroupBox enables a caption to the container but no scrolling feature if a control is out of boundary.
 * Panel enables scrolling feature but does not have a caption.
 * 
 * Upper container control is a GroupBox.
 *    Name = "mainGroupBox"
 *    Text = "Main GroupBox"
 *    
 * Lower container control is a Panel.
 *    Name = "mainPanel"
 *    AutoScroll = True
 
 */



using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class GroupBoxPanelExampleForm : Form
   {
      public GroupBoxPanelExampleForm()
      {
         InitializeComponent();
      }//end constructor GroupBoxPanelExampleForm


      /** Event handler for Hi button **/
      private void hiButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Hi pressed";

      }//end method hiButton_Click


      /** Event handler for Bye button **/
      private void byeButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Bye pressed";

      }//end method byeButton_Click


      /** Event handler for Left button **/
      private void leftButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Far left pressed";

      }//end method leftButton_Click


      /** Event handler for right button **/
      private void rightButton_Click(object sender, EventArgs e)
      {
         messageLabel.Text = "Far right pressed";

      }//end method rightButton_Click

   }//end class GroupBoxPanelExampleForm
}
