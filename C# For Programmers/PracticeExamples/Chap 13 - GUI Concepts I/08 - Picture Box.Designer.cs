namespace Chap_13_GUI_1
{
   partial class PictureBoxTestForm
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
         this.imagePictureBox = new System.Windows.Forms.PictureBox();
         this.nextButton = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // imagePictureBox
         // 
         this.imagePictureBox.Location = new System.Drawing.Point(47, 78);
         this.imagePictureBox.Name = "imagePictureBox";
         this.imagePictureBox.Size = new System.Drawing.Size(191, 131);
         this.imagePictureBox.TabIndex = 0;
         this.imagePictureBox.TabStop = false;
         // 
         // nextButton
         // 
         this.nextButton.Location = new System.Drawing.Point(100, 35);
         this.nextButton.Name = "nextButton";
         this.nextButton.Size = new System.Drawing.Size(75, 23);
         this.nextButton.TabIndex = 1;
         this.nextButton.Text = "Next Image";
         this.nextButton.UseVisualStyleBackColor = true;
         this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
         // 
         // PictureBoxTestForm
         // 
         this.AcceptButton = this.nextButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 261);
         this.Controls.Add(this.nextButton);
         this.Controls.Add(this.imagePictureBox);
         this.Name = "PictureBoxTestForm";
         this.Text = "Picture Box Test";
         ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox imagePictureBox;
      private System.Windows.Forms.Button nextButton;
   }
}