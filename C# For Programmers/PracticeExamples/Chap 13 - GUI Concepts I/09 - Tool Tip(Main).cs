using System;
using System.Windows.Forms;

namespace Chap_13_GUI_1
{
   static class TooltipExampleMain
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new TooltipExampleForm());
      }
   }
}
