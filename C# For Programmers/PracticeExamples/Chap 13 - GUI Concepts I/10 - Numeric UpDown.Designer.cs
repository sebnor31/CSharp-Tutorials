namespace Chap_13_GUI_1
{
   partial class InterestCalculatorForm
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
         this.principalTextBox = new System.Windows.Forms.NumericUpDown();
         this.interestTextBox = new System.Windows.Forms.NumericUpDown();
         this.yearUpDown = new System.Windows.Forms.NumericUpDown();
         this.displayTextBox = new System.Windows.Forms.TextBox();
         this.calculateButton = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.principalTextBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.interestTextBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
         this.SuspendLayout();
         // 
         // principalTextBox
         // 
         this.principalTextBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
         this.principalTextBox.Location = new System.Drawing.Point(34, 17);
         this.principalTextBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.principalTextBox.Name = "principalTextBox";
         this.principalTextBox.Size = new System.Drawing.Size(120, 20);
         this.principalTextBox.TabIndex = 0;
         this.principalTextBox.ThousandsSeparator = true;
         this.principalTextBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
         // 
         // interestTextBox
         // 
         this.interestTextBox.Location = new System.Drawing.Point(34, 43);
         this.interestTextBox.Name = "interestTextBox";
         this.interestTextBox.Size = new System.Drawing.Size(120, 20);
         this.interestTextBox.TabIndex = 1;
         this.interestTextBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
         // 
         // yearUpDown
         // 
         this.yearUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.yearUpDown.Location = new System.Drawing.Point(34, 69);
         this.yearUpDown.Name = "yearUpDown";
         this.yearUpDown.ReadOnly = true;
         this.yearUpDown.Size = new System.Drawing.Size(120, 20);
         this.yearUpDown.TabIndex = 2;
         this.yearUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         // 
         // displayTextBox
         // 
         this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.displayTextBox.Location = new System.Drawing.Point(34, 95);
         this.displayTextBox.Multiline = true;
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.ReadOnly = true;
         this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.displayTextBox.Size = new System.Drawing.Size(197, 154);
         this.displayTextBox.TabIndex = 3;
         this.displayTextBox.Text = "Press Calculate...";
         // 
         // calculateButton
         // 
         this.calculateButton.Location = new System.Drawing.Point(190, 18);
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.Size = new System.Drawing.Size(75, 23);
         this.calculateButton.TabIndex = 4;
         this.calculateButton.Text = "Calculate";
         this.calculateButton.UseVisualStyleBackColor = true;
         this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
         // 
         // InterestCalculatorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 261);
         this.Controls.Add(this.calculateButton);
         this.Controls.Add(this.displayTextBox);
         this.Controls.Add(this.yearUpDown);
         this.Controls.Add(this.interestTextBox);
         this.Controls.Add(this.principalTextBox);
         this.Name = "InterestCalculatorForm";
         this.Text = "Numeric UpDown";
         ((System.ComponentModel.ISupportInitialize)(this.principalTextBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.interestTextBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.NumericUpDown principalTextBox;
      private System.Windows.Forms.NumericUpDown interestTextBox;
      private System.Windows.Forms.NumericUpDown yearUpDown;
      private System.Windows.Forms.TextBox displayTextBox;
      private System.Windows.Forms.Button calculateButton;
   }
}