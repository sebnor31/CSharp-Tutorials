/* A Picture Box is used to display a picture.
 * In this exple, 3 images are found in a directory and are displayed sequentially at each click to "Next image" button.
 * A modulo is used to reinitialize the image reference.  
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class PictureBoxTestForm : Form
   {
      /* Instance variable */
      private int imageNum = 0;

      /* Constructor */
      public PictureBoxTestForm()
      {
         InitializeComponent();
      }//end constructor

      /* Event Handler */
      private void nextButton_Click(object sender, EventArgs e)
      {
         // image reference values are 0-1-2
         imageNum = (imageNum + 1) % 3;

         imagePictureBox.Image = Image.FromFile(
            "C:\\GitHub\\Nordine Sebkhi\\CSharp-Tutorials\\C# For Programmers\\PracticeExamples\\Chap 13 - GUI Concepts I\\Images\\image" + imageNum + ".jpg");
      }//end event nextButton_Click

   }//end class PictureBoxTestForm

}//end namespace Chap_13_GUI_1
