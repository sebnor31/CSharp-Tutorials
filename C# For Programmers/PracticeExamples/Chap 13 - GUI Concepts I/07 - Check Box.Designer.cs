namespace Chap_13_GUI_1
{
   partial class CheckBoxTestForm
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
         this.outputLabel = new System.Windows.Forms.Label();
         this.boldCheckBox = new System.Windows.Forms.CheckBox();
         this.italicCheckBox = new System.Windows.Forms.CheckBox();
         this.SuspendLayout();
         // 
         // outputLabel
         // 
         this.outputLabel.AutoSize = true;
         this.outputLabel.Location = new System.Drawing.Point(38, 30);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(141, 13);
         this.outputLabel.TabIndex = 0;
         this.outputLabel.Text = "Watch the font style change";
         // 
         // boldCheckBox
         // 
         this.boldCheckBox.AutoSize = true;
         this.boldCheckBox.Location = new System.Drawing.Point(41, 88);
         this.boldCheckBox.Name = "boldCheckBox";
         this.boldCheckBox.Size = new System.Drawing.Size(47, 17);
         this.boldCheckBox.TabIndex = 1;
         this.boldCheckBox.Text = "Bold";
         this.boldCheckBox.UseVisualStyleBackColor = true;
         this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
         // 
         // italicCheckBox
         // 
         this.italicCheckBox.AutoSize = true;
         this.italicCheckBox.Location = new System.Drawing.Point(147, 88);
         this.italicCheckBox.Name = "italicCheckBox";
         this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
         this.italicCheckBox.TabIndex = 1;
         this.italicCheckBox.Text = "Italic";
         this.italicCheckBox.UseVisualStyleBackColor = true;
         this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);
         // 
         // CheckBoxTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(248, 137);
         this.Controls.Add(this.italicCheckBox);
         this.Controls.Add(this.boldCheckBox);
         this.Controls.Add(this.outputLabel);
         this.Name = "CheckBoxTestForm";
         this.Text = "CheckBoxTest";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label outputLabel;
      private System.Windows.Forms.CheckBox boldCheckBox;
      private System.Windows.Forms.CheckBox italicCheckBox;
   }
}