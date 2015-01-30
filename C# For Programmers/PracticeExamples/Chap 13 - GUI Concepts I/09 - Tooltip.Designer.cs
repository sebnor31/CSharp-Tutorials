namespace Chap_13_GUI_1
{
   partial class TooltipExampleForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.topLabel = new System.Windows.Forms.Label();
         this.bottomLabel = new System.Windows.Forms.Label();
         this.labelsToolTip = new System.Windows.Forms.ToolTip(this.components);
         this.SuspendLayout();
         // 
         // topLabel
         // 
         this.topLabel.AutoSize = true;
         this.topLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.topLabel.Location = new System.Drawing.Point(72, 60);
         this.topLabel.Name = "topLabel";
         this.topLabel.Size = new System.Drawing.Size(73, 15);
         this.topLabel.TabIndex = 0;
         this.topLabel.Text = "This is a label";
         this.labelsToolTip.SetToolTip(this.topLabel, "First LAbel");
         // 
         // bottomLabel
         // 
         this.bottomLabel.AutoSize = true;
         this.bottomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.bottomLabel.Location = new System.Drawing.Point(72, 121);
         this.bottomLabel.Name = "bottomLabel";
         this.bottomLabel.Size = new System.Drawing.Size(103, 15);
         this.bottomLabel.TabIndex = 1;
         this.bottomLabel.Text = "This is another label";
         this.labelsToolTip.SetToolTip(this.bottomLabel, "Second Label");
         // 
         // labelsToolTip
         // 
         this.labelsToolTip.AutoPopDelay = 5000;
         this.labelsToolTip.InitialDelay = 100;
         this.labelsToolTip.IsBalloon = true;
         this.labelsToolTip.ReshowDelay = 100;
         // 
         // TooltipExampleForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 261);
         this.Controls.Add(this.bottomLabel);
         this.Controls.Add(this.topLabel);
         this.Name = "TooltipExampleForm";
         this.Text = "Tooltip Test";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label topLabel;
      private System.Windows.Forms.Label bottomLabel;
      private System.Windows.Forms.ToolTip labelsToolTip;
   }
}