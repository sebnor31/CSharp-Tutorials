namespace Chap_13_GUI_1
{
   partial class RadioButtonsTestForm
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
         this.buttonTypeGroupBox = new System.Windows.Forms.GroupBox();
         this.iconGroupBox = new System.Windows.Forms.GroupBox();
         this.displayButton = new System.Windows.Forms.Button();
         this.displayLabel = new System.Windows.Forms.Label();
         this.okayButton = new System.Windows.Forms.RadioButton();
         this.okayCancelButton = new System.Windows.Forms.RadioButton();
         this.asteriskButton = new System.Windows.Forms.RadioButton();
         this.errorButton = new System.Windows.Forms.RadioButton();
         this.abortRetryIgnoreButton = new System.Windows.Forms.RadioButton();
         this.yesNoCancelButton = new System.Windows.Forms.RadioButton();
         this.yesNoButton = new System.Windows.Forms.RadioButton();
         this.retryCancelButton = new System.Windows.Forms.RadioButton();
         this.exclamationButton = new System.Windows.Forms.RadioButton();
         this.handButton = new System.Windows.Forms.RadioButton();
         this.informationButton = new System.Windows.Forms.RadioButton();
         this.questionButton = new System.Windows.Forms.RadioButton();
         this.stopButton = new System.Windows.Forms.RadioButton();
         this.warningButton = new System.Windows.Forms.RadioButton();
         this.buttonTypeGroupBox.SuspendLayout();
         this.iconGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // buttonTypeGroupBox
         // 
         this.buttonTypeGroupBox.Controls.Add(this.retryCancelButton);
         this.buttonTypeGroupBox.Controls.Add(this.yesNoButton);
         this.buttonTypeGroupBox.Controls.Add(this.yesNoCancelButton);
         this.buttonTypeGroupBox.Controls.Add(this.abortRetryIgnoreButton);
         this.buttonTypeGroupBox.Controls.Add(this.okayCancelButton);
         this.buttonTypeGroupBox.Controls.Add(this.okayButton);
         this.buttonTypeGroupBox.Location = new System.Drawing.Point(26, 16);
         this.buttonTypeGroupBox.Name = "buttonTypeGroupBox";
         this.buttonTypeGroupBox.Size = new System.Drawing.Size(136, 171);
         this.buttonTypeGroupBox.TabIndex = 0;
         this.buttonTypeGroupBox.TabStop = false;
         this.buttonTypeGroupBox.Text = "Button Type";
         // 
         // iconGroupBox
         // 
         this.iconGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.iconGroupBox.Controls.Add(this.warningButton);
         this.iconGroupBox.Controls.Add(this.stopButton);
         this.iconGroupBox.Controls.Add(this.questionButton);
         this.iconGroupBox.Controls.Add(this.informationButton);
         this.iconGroupBox.Controls.Add(this.handButton);
         this.iconGroupBox.Controls.Add(this.exclamationButton);
         this.iconGroupBox.Controls.Add(this.errorButton);
         this.iconGroupBox.Controls.Add(this.asteriskButton);
         this.iconGroupBox.Location = new System.Drawing.Point(196, 16);
         this.iconGroupBox.Name = "iconGroupBox";
         this.iconGroupBox.Size = new System.Drawing.Size(106, 212);
         this.iconGroupBox.TabIndex = 0;
         this.iconGroupBox.TabStop = false;
         this.iconGroupBox.Text = "Icon";
         // 
         // displayButton
         // 
         this.displayButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
         this.displayButton.Location = new System.Drawing.Point(38, 203);
         this.displayButton.Name = "displayButton";
         this.displayButton.Size = new System.Drawing.Size(75, 23);
         this.displayButton.TabIndex = 1;
         this.displayButton.Text = "Display";
         this.displayButton.UseVisualStyleBackColor = true;
         this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
         // 
         // displayLabel
         // 
         this.displayLabel.AutoSize = true;
         this.displayLabel.Location = new System.Drawing.Point(23, 239);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(25, 13);
         this.displayLabel.TabIndex = 2;
         this.displayLabel.Text = "Null";
         // 
         // okayButton
         // 
         this.okayButton.AutoSize = true;
         this.okayButton.Checked = true;
         this.okayButton.Location = new System.Drawing.Point(15, 20);
         this.okayButton.Name = "okayButton";
         this.okayButton.Size = new System.Drawing.Size(39, 17);
         this.okayButton.TabIndex = 0;
         this.okayButton.TabStop = true;
         this.okayButton.Text = "Ok";
         this.okayButton.UseVisualStyleBackColor = true;
         this.okayButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
         // 
         // okayCancelButton
         // 
         this.okayCancelButton.AutoSize = true;
         this.okayCancelButton.Location = new System.Drawing.Point(15, 44);
         this.okayCancelButton.Name = "okayCancelButton";
         this.okayCancelButton.Size = new System.Drawing.Size(78, 17);
         this.okayCancelButton.TabIndex = 1;
         this.okayCancelButton.Text = "Ok_Cancel";
         this.okayCancelButton.UseVisualStyleBackColor = true;
         this.okayCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
         // 
         // asteriskButton
         // 
         this.asteriskButton.AutoSize = true;
         this.asteriskButton.Location = new System.Drawing.Point(7, 20);
         this.asteriskButton.Name = "asteriskButton";
         this.asteriskButton.Size = new System.Drawing.Size(62, 17);
         this.asteriskButton.TabIndex = 0;
         this.asteriskButton.TabStop = true;
         this.asteriskButton.Text = "Asterisk";
         this.asteriskButton.UseVisualStyleBackColor = true;
         this.asteriskButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
         // 
         // errorButton
         // 
         this.errorButton.AutoSize = true;
         this.errorButton.Location = new System.Drawing.Point(7, 44);
         this.errorButton.Name = "errorButton";
         this.errorButton.Size = new System.Drawing.Size(47, 17);
         this.errorButton.TabIndex = 1;
         this.errorButton.TabStop = true;
         this.errorButton.Text = "Error";
         this.errorButton.UseVisualStyleBackColor = true;
         this.errorButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
         // 
         // abortRetryIgnoreButton
         // 
         this.abortRetryIgnoreButton.AutoSize = true;
         this.abortRetryIgnoreButton.Location = new System.Drawing.Point(15, 68);
         this.abortRetryIgnoreButton.Name = "abortRetryIgnoreButton";
         this.abortRetryIgnoreButton.Size = new System.Drawing.Size(117, 17);
         this.abortRetryIgnoreButton.TabIndex = 2;
         this.abortRetryIgnoreButton.Text = "Abort_Retry_Ignore";
         this.abortRetryIgnoreButton.UseVisualStyleBackColor = true;
         this.abortRetryIgnoreButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
         // 
         // yesNoCancelButton
         // 
         this.yesNoCancelButton.AutoSize = true;
         this.yesNoCancelButton.Location = new System.Drawing.Point(15, 92);
         this.yesNoCancelButton.Name = "yesNoCancelButton";
         this.yesNoCancelButton.Size = new System.Drawing.Size(102, 17);
         this.yesNoCancelButton.TabIndex = 3;
         this.yesNoCancelButton.Text = "Yes_No_Cancel";
         this.yesNoCancelButton.UseVisualStyleBackColor = true;
         this.yesNoCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
         // 
         // yesNoButton
         // 
         this.yesNoButton.AutoSize = true;
         this.yesNoButton.Location = new System.Drawing.Point(15, 116);
         this.yesNoButton.Name = "yesNoButton";
         this.yesNoButton.Size = new System.Drawing.Size(63, 17);
         this.yesNoButton.TabIndex = 4;
         this.yesNoButton.Text = "Yes_No";
         this.yesNoButton.UseVisualStyleBackColor = true;
         this.yesNoButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
         // 
         // retryCancelButton
         // 
         this.retryCancelButton.AutoSize = true;
         this.retryCancelButton.Location = new System.Drawing.Point(15, 140);
         this.retryCancelButton.Name = "retryCancelButton";
         this.retryCancelButton.Size = new System.Drawing.Size(89, 17);
         this.retryCancelButton.TabIndex = 5;
         this.retryCancelButton.Text = "Retry_Cancel";
         this.retryCancelButton.UseVisualStyleBackColor = true;
         this.retryCancelButton.CheckedChanged += new System.EventHandler(this.buttonType_CheckedChanged);
         // 
         // exclamationButton
         // 
         this.exclamationButton.AutoSize = true;
         this.exclamationButton.Location = new System.Drawing.Point(7, 68);
         this.exclamationButton.Name = "exclamationButton";
         this.exclamationButton.Size = new System.Drawing.Size(82, 17);
         this.exclamationButton.TabIndex = 2;
         this.exclamationButton.TabStop = true;
         this.exclamationButton.Text = "Exclamation";
         this.exclamationButton.UseVisualStyleBackColor = true;
         this.exclamationButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
         // 
         // handButton
         // 
         this.handButton.AutoSize = true;
         this.handButton.Location = new System.Drawing.Point(7, 92);
         this.handButton.Name = "handButton";
         this.handButton.Size = new System.Drawing.Size(51, 17);
         this.handButton.TabIndex = 3;
         this.handButton.TabStop = true;
         this.handButton.Text = "Hand";
         this.handButton.UseVisualStyleBackColor = true;
         this.handButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
         // 
         // informationButton
         // 
         this.informationButton.AutoSize = true;
         this.informationButton.Location = new System.Drawing.Point(7, 116);
         this.informationButton.Name = "informationButton";
         this.informationButton.Size = new System.Drawing.Size(77, 17);
         this.informationButton.TabIndex = 4;
         this.informationButton.TabStop = true;
         this.informationButton.Text = "Information";
         this.informationButton.UseVisualStyleBackColor = true;
         this.informationButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
         // 
         // questionButton
         // 
         this.questionButton.AutoSize = true;
         this.questionButton.Location = new System.Drawing.Point(7, 140);
         this.questionButton.Name = "questionButton";
         this.questionButton.Size = new System.Drawing.Size(67, 17);
         this.questionButton.TabIndex = 5;
         this.questionButton.TabStop = true;
         this.questionButton.Text = "Question";
         this.questionButton.UseVisualStyleBackColor = true;
         this.questionButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
         // 
         // stopButton
         // 
         this.stopButton.AutoSize = true;
         this.stopButton.Location = new System.Drawing.Point(7, 164);
         this.stopButton.Name = "stopButton";
         this.stopButton.Size = new System.Drawing.Size(47, 17);
         this.stopButton.TabIndex = 6;
         this.stopButton.TabStop = true;
         this.stopButton.Text = "Stop";
         this.stopButton.UseVisualStyleBackColor = true;
         this.stopButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
         // 
         // warningButton
         // 
         this.warningButton.AutoSize = true;
         this.warningButton.Location = new System.Drawing.Point(7, 188);
         this.warningButton.Name = "warningButton";
         this.warningButton.Size = new System.Drawing.Size(65, 17);
         this.warningButton.TabIndex = 7;
         this.warningButton.TabStop = true;
         this.warningButton.Text = "Warning";
         this.warningButton.UseVisualStyleBackColor = true;
         this.warningButton.CheckedChanged += new System.EventHandler(this.iconType_CheckedChanged);
         // 
         // RadioButtonsTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(340, 261);
         this.Controls.Add(this.displayLabel);
         this.Controls.Add(this.displayButton);
         this.Controls.Add(this.iconGroupBox);
         this.Controls.Add(this.buttonTypeGroupBox);
         this.Name = "RadioButtonsTestForm";
         this.Text = "Radio Button Test";
         this.buttonTypeGroupBox.ResumeLayout(false);
         this.buttonTypeGroupBox.PerformLayout();
         this.iconGroupBox.ResumeLayout(false);
         this.iconGroupBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox buttonTypeGroupBox;
      private System.Windows.Forms.GroupBox iconGroupBox;
      private System.Windows.Forms.Button displayButton;
      private System.Windows.Forms.Label displayLabel;
      private System.Windows.Forms.RadioButton okayCancelButton;
      private System.Windows.Forms.RadioButton okayButton;
      private System.Windows.Forms.RadioButton errorButton;
      private System.Windows.Forms.RadioButton asteriskButton;
      private System.Windows.Forms.RadioButton retryCancelButton;
      private System.Windows.Forms.RadioButton yesNoButton;
      private System.Windows.Forms.RadioButton yesNoCancelButton;
      private System.Windows.Forms.RadioButton abortRetryIgnoreButton;
      private System.Windows.Forms.RadioButton warningButton;
      private System.Windows.Forms.RadioButton stopButton;
      private System.Windows.Forms.RadioButton questionButton;
      private System.Windows.Forms.RadioButton informationButton;
      private System.Windows.Forms.RadioButton handButton;
      private System.Windows.Forms.RadioButton exclamationButton;
   }
}