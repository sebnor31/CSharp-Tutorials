namespace Chap_13_GUI_1
{
   partial class LabelTextButton
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
         this.displayPasswordButton = new System.Windows.Forms.Button();
         this.displayPasswordLabel = new System.Windows.Forms.Label();
         this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // displayPasswordButton
         // 
         this.displayPasswordButton.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.displayPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.displayPasswordButton.Location = new System.Drawing.Point(0, 238);
         this.displayPasswordButton.Name = "displayPasswordButton";
         this.displayPasswordButton.Size = new System.Drawing.Size(284, 23);
         this.displayPasswordButton.TabIndex = 0;
         this.displayPasswordButton.Text = "Show Me";
         this.displayPasswordButton.UseVisualStyleBackColor = true;
         this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
         // 
         // displayPasswordLabel
         // 
         this.displayPasswordLabel.AutoSize = true;
         this.displayPasswordLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
         this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.displayPasswordLabel.Location = new System.Drawing.Point(54, 84);
         this.displayPasswordLabel.Name = "displayPasswordLabel";
         this.displayPasswordLabel.Padding = new System.Windows.Forms.Padding(10);
         this.displayPasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.displayPasswordLabel.Size = new System.Drawing.Size(22, 35);
         this.displayPasswordLabel.TabIndex = 1;
         // 
         // inputPasswordTextBox
         // 
         this.inputPasswordTextBox.Location = new System.Drawing.Point(54, 44);
         this.inputPasswordTextBox.Name = "inputPasswordTextBox";
         this.inputPasswordTextBox.PasswordChar = '*';
         this.inputPasswordTextBox.Size = new System.Drawing.Size(184, 20);
         this.inputPasswordTextBox.TabIndex = 2;
         // 
         // LabelTextButton
         // 
         this.AcceptButton = this.displayPasswordButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 261);
         this.Controls.Add(this.inputPasswordTextBox);
         this.Controls.Add(this.displayPasswordLabel);
         this.Controls.Add(this.displayPasswordButton);
         this.Name = "LabelTextButton";
         this.Text = "LabelTextButton Test";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button displayPasswordButton;
      private System.Windows.Forms.Label displayPasswordLabel;
      private System.Windows.Forms.TextBox inputPasswordTextBox;
   }
}

