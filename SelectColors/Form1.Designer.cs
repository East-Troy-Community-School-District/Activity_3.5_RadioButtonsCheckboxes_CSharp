
namespace SelectColors
{
    partial class SelectColorsForm
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
            this.foregroundColor = new System.Windows.Forms.GroupBox();
            this.backgroundColor = new System.Windows.Forms.GroupBox();
            this.applyColorButton = new System.Windows.Forms.Button();
            this.whiteForeRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowForeRadioButton = new System.Windows.Forms.RadioButton();
            this.redForeRadioButton = new System.Windows.Forms.RadioButton();
            this.blueForeRadioButton = new System.Windows.Forms.RadioButton();
            this.blueBackRadioButton = new System.Windows.Forms.RadioButton();
            this.redBackRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowBackRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteBackRadioButton = new System.Windows.Forms.RadioButton();
            this.outputLabel = new System.Windows.Forms.Label();
            this.foregroundColor.SuspendLayout();
            this.backgroundColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // foregroundColor
            // 
            this.foregroundColor.Controls.Add(this.blueForeRadioButton);
            this.foregroundColor.Controls.Add(this.redForeRadioButton);
            this.foregroundColor.Controls.Add(this.yellowForeRadioButton);
            this.foregroundColor.Controls.Add(this.whiteForeRadioButton);
            this.foregroundColor.Location = new System.Drawing.Point(12, 12);
            this.foregroundColor.Name = "foregroundColor";
            this.foregroundColor.Size = new System.Drawing.Size(118, 137);
            this.foregroundColor.TabIndex = 0;
            this.foregroundColor.TabStop = false;
            this.foregroundColor.Text = "Foreground Color";
            // 
            // backgroundColor
            // 
            this.backgroundColor.Controls.Add(this.blueBackRadioButton);
            this.backgroundColor.Controls.Add(this.redBackRadioButton);
            this.backgroundColor.Controls.Add(this.yellowBackRadioButton);
            this.backgroundColor.Controls.Add(this.whiteBackRadioButton);
            this.backgroundColor.Location = new System.Drawing.Point(136, 11);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(118, 137);
            this.backgroundColor.TabIndex = 1;
            this.backgroundColor.TabStop = false;
            this.backgroundColor.Text = "Background Color";
            // 
            // applyColorButton
            // 
            this.applyColorButton.AutoSize = true;
            this.applyColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyColorButton.Location = new System.Drawing.Point(260, 11);
            this.applyColorButton.Name = "applyColorButton";
            this.applyColorButton.Size = new System.Drawing.Size(118, 65);
            this.applyColorButton.TabIndex = 2;
            this.applyColorButton.Text = "Apply Color";
            this.applyColorButton.UseVisualStyleBackColor = true;
            this.applyColorButton.Click += new System.EventHandler(this.applyColorButton_Click);
            // 
            // whiteForeRadioButton
            // 
            this.whiteForeRadioButton.AutoSize = true;
            this.whiteForeRadioButton.Checked = true;
            this.whiteForeRadioButton.Location = new System.Drawing.Point(31, 24);
            this.whiteForeRadioButton.Name = "whiteForeRadioButton";
            this.whiteForeRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteForeRadioButton.TabIndex = 0;
            this.whiteForeRadioButton.TabStop = true;
            this.whiteForeRadioButton.Text = "White";
            this.whiteForeRadioButton.UseVisualStyleBackColor = true;
            // 
            // yellowForeRadioButton
            // 
            this.yellowForeRadioButton.AutoSize = true;
            this.yellowForeRadioButton.Location = new System.Drawing.Point(31, 48);
            this.yellowForeRadioButton.Name = "yellowForeRadioButton";
            this.yellowForeRadioButton.Size = new System.Drawing.Size(56, 17);
            this.yellowForeRadioButton.TabIndex = 1;
            this.yellowForeRadioButton.Text = "Yellow";
            this.yellowForeRadioButton.UseVisualStyleBackColor = true;
            // 
            // redForeRadioButton
            // 
            this.redForeRadioButton.AutoSize = true;
            this.redForeRadioButton.Location = new System.Drawing.Point(31, 72);
            this.redForeRadioButton.Name = "redForeRadioButton";
            this.redForeRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redForeRadioButton.TabIndex = 2;
            this.redForeRadioButton.Text = "Red";
            this.redForeRadioButton.UseVisualStyleBackColor = true;
            // 
            // blueForeRadioButton
            // 
            this.blueForeRadioButton.AutoSize = true;
            this.blueForeRadioButton.Location = new System.Drawing.Point(31, 95);
            this.blueForeRadioButton.Name = "blueForeRadioButton";
            this.blueForeRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blueForeRadioButton.TabIndex = 3;
            this.blueForeRadioButton.Text = "Blue";
            this.blueForeRadioButton.UseVisualStyleBackColor = true;
            // 
            // blueBackRadioButton
            // 
            this.blueBackRadioButton.AutoSize = true;
            this.blueBackRadioButton.Checked = true;
            this.blueBackRadioButton.Location = new System.Drawing.Point(31, 96);
            this.blueBackRadioButton.Name = "blueBackRadioButton";
            this.blueBackRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blueBackRadioButton.TabIndex = 7;
            this.blueBackRadioButton.TabStop = true;
            this.blueBackRadioButton.Text = "Blue";
            this.blueBackRadioButton.UseVisualStyleBackColor = true;
            // 
            // redBackRadioButton
            // 
            this.redBackRadioButton.AutoSize = true;
            this.redBackRadioButton.Location = new System.Drawing.Point(31, 72);
            this.redBackRadioButton.Name = "redBackRadioButton";
            this.redBackRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redBackRadioButton.TabIndex = 6;
            this.redBackRadioButton.Text = "Red";
            this.redBackRadioButton.UseVisualStyleBackColor = true;
            // 
            // yellowBackRadioButton
            // 
            this.yellowBackRadioButton.AutoSize = true;
            this.yellowBackRadioButton.Location = new System.Drawing.Point(31, 48);
            this.yellowBackRadioButton.Name = "yellowBackRadioButton";
            this.yellowBackRadioButton.Size = new System.Drawing.Size(56, 17);
            this.yellowBackRadioButton.TabIndex = 5;
            this.yellowBackRadioButton.Text = "Yellow";
            this.yellowBackRadioButton.UseVisualStyleBackColor = true;
            // 
            // whiteBackRadioButton
            // 
            this.whiteBackRadioButton.AutoSize = true;
            this.whiteBackRadioButton.Location = new System.Drawing.Point(31, 24);
            this.whiteBackRadioButton.Name = "whiteBackRadioButton";
            this.whiteBackRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteBackRadioButton.TabIndex = 4;
            this.whiteBackRadioButton.Text = "White";
            this.whiteBackRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Blue;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(21, 157);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(366, 55);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "C# is awesome!";
            // 
            // SelectColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 222);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.applyColorButton);
            this.Controls.Add(this.backgroundColor);
            this.Controls.Add(this.foregroundColor);
            this.Name = "SelectColorsForm";
            this.Text = "Select Colors";
            this.foregroundColor.ResumeLayout(false);
            this.foregroundColor.PerformLayout();
            this.backgroundColor.ResumeLayout(false);
            this.backgroundColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox foregroundColor;
        private System.Windows.Forms.RadioButton blueForeRadioButton;
        private System.Windows.Forms.RadioButton redForeRadioButton;
        private System.Windows.Forms.RadioButton yellowForeRadioButton;
        private System.Windows.Forms.RadioButton whiteForeRadioButton;
        private System.Windows.Forms.GroupBox backgroundColor;
        private System.Windows.Forms.RadioButton blueBackRadioButton;
        private System.Windows.Forms.RadioButton redBackRadioButton;
        private System.Windows.Forms.RadioButton yellowBackRadioButton;
        private System.Windows.Forms.RadioButton whiteBackRadioButton;
        private System.Windows.Forms.Button applyColorButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

