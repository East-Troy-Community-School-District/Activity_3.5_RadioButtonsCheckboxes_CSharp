
namespace ComputerCost
{
    partial class ComputerCostForm
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
            this.modelGroupBox = new System.Windows.Forms.GroupBox();
            this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.superRadioButton = new System.Windows.Forms.RadioButton();
            this.videoCardCheckBox = new System.Windows.Forms.CheckBox();
            this.wifiCheckBox = new System.Windows.Forms.CheckBox();
            this.memoryCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.modelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelGroupBox
            // 
            this.modelGroupBox.Controls.Add(this.superRadioButton);
            this.modelGroupBox.Controls.Add(this.deluxeRadioButton);
            this.modelGroupBox.Location = new System.Drawing.Point(19, 10);
            this.modelGroupBox.Name = "modelGroupBox";
            this.modelGroupBox.Size = new System.Drawing.Size(207, 72);
            this.modelGroupBox.TabIndex = 0;
            this.modelGroupBox.TabStop = false;
            this.modelGroupBox.Text = "Model";
            // 
            // deluxeRadioButton
            // 
            this.deluxeRadioButton.AutoSize = true;
            this.deluxeRadioButton.Checked = true;
            this.deluxeRadioButton.Location = new System.Drawing.Point(31, 28);
            this.deluxeRadioButton.Name = "deluxeRadioButton";
            this.deluxeRadioButton.Size = new System.Drawing.Size(58, 17);
            this.deluxeRadioButton.TabIndex = 0;
            this.deluxeRadioButton.TabStop = true;
            this.deluxeRadioButton.Text = "Deluxe";
            this.deluxeRadioButton.UseVisualStyleBackColor = true;
            // 
            // superRadioButton
            // 
            this.superRadioButton.AutoSize = true;
            this.superRadioButton.Location = new System.Drawing.Point(122, 28);
            this.superRadioButton.Name = "superRadioButton";
            this.superRadioButton.Size = new System.Drawing.Size(53, 17);
            this.superRadioButton.TabIndex = 1;
            this.superRadioButton.Text = "Super";
            this.superRadioButton.UseVisualStyleBackColor = true;
            // 
            // videoCardCheckBox
            // 
            this.videoCardCheckBox.AutoSize = true;
            this.videoCardCheckBox.Location = new System.Drawing.Point(53, 88);
            this.videoCardCheckBox.Name = "videoCardCheckBox";
            this.videoCardCheckBox.Size = new System.Drawing.Size(128, 17);
            this.videoCardCheckBox.TabIndex = 1;
            this.videoCardCheckBox.Text = "Upgraded Video Card";
            this.videoCardCheckBox.UseVisualStyleBackColor = true;
            // 
            // wifiCheckBox
            // 
            this.wifiCheckBox.AutoSize = true;
            this.wifiCheckBox.Location = new System.Drawing.Point(53, 111);
            this.wifiCheckBox.Name = "wifiCheckBox";
            this.wifiCheckBox.Size = new System.Drawing.Size(135, 17);
            this.wifiCheckBox.TabIndex = 2;
            this.wifiCheckBox.Text = "Internal Modem + Wi-Fi";
            this.wifiCheckBox.UseVisualStyleBackColor = true;
            // 
            // memoryCheckBox
            // 
            this.memoryCheckBox.AutoSize = true;
            this.memoryCheckBox.Location = new System.Drawing.Point(53, 134);
            this.memoryCheckBox.Name = "memoryCheckBox";
            this.memoryCheckBox.Size = new System.Drawing.Size(139, 17);
            this.memoryCheckBox.TabIndex = 3;
            this.memoryCheckBox.Text = "1 GB Additional Memory";
            this.memoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Cost:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(104, 205);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 5;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.AutoSize = true;
            this.calculateTotalButton.Location = new System.Drawing.Point(78, 166);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(88, 23);
            this.calculateTotalButton.TabIndex = 6;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // ComputerCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 239);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memoryCheckBox);
            this.Controls.Add(this.wifiCheckBox);
            this.Controls.Add(this.videoCardCheckBox);
            this.Controls.Add(this.modelGroupBox);
            this.Name = "ComputerCostForm";
            this.Text = "Computer Cost";
            this.modelGroupBox.ResumeLayout(false);
            this.modelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox modelGroupBox;
        private System.Windows.Forms.RadioButton superRadioButton;
        private System.Windows.Forms.RadioButton deluxeRadioButton;
        private System.Windows.Forms.CheckBox videoCardCheckBox;
        private System.Windows.Forms.CheckBox wifiCheckBox;
        private System.Windows.Forms.CheckBox memoryCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateTotalButton;
    }
}

