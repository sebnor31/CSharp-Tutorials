/* When a tooltip is created, it is placed on the component tray in the designer view.
 * A new property shows up on every label of the form and a text can be associated to the tooltip.
 * 
 * NOTE: A tooltip control can be shared among multiple labels, but each label has its own text associated to the tooltip.
 * */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   public partial class TooltipExampleForm : Form
   {
      /* Constructor */
      public TooltipExampleForm()
      {
         InitializeComponent();
      }//end constructor

      /* NO EVENT HANDLER */

   }//end class TooltipExampleForm

}//end namespace Chap_13_GUI_1
