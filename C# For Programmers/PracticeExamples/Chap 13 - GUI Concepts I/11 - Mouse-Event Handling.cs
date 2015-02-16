/* Create a painting form where ellipsis are formed when a mouse button is pressed and moving
 * Mouse Down (button click) => Enable painting
 * Mouse Up (release button) => Disable painting
  */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class PainterForm : Form
   {
      /* Instance variable */
      bool shouldPaint = false;  // determine whether to paint

      public PainterForm()
      {
         InitializeComponent();
      }//end constructor

      private void PainterForm_MouseDown(object sender, MouseEventArgs e)
      {
         shouldPaint = true;
      }//end event PainterForm_MouseDown

      private void PainterForm_MouseUp(object sender, MouseEventArgs e)
      {
         shouldPaint = false;
      }//end event PainterForm_MouseUp

      private void PainterForm_MouseMove(object sender, MouseEventArgs e)
      {
         if (shouldPaint)
         {
            Graphics graphics = CreateGraphics();
            graphics.FillEllipse(new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
            graphics.Dispose();
         }//end if

      }//end event PainterForm_MouseMove

   }//end class PainterForm

}//end namespace
