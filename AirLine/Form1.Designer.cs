
namespace AirLine
{
    partial class AirlineForm
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
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.bookFlightButton = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.Items.AddRange(new object[] {
            "AUS",
            "BOS",
            "BWI",
            "DFW",
            "JFK",
            "LAX",
            "MIA",
            "ORD",
            "SFO"});
            this.fromListBox.Location = new System.Drawing.Point(33, 40);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(53, 121);
            this.fromListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.Items.AddRange(new object[] {
            "AUS",
            "BOS",
            "BWI",
            "DFW",
            "JFK",
            "LAX",
            "MIA",
            "ORD",
            "SFO"});
            this.toListBox.Location = new System.Drawing.Point(114, 40);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(53, 121);
            this.toListBox.TabIndex = 2;
            // 
            // bookFlightButton
            // 
            this.bookFlightButton.Location = new System.Drawing.Point(189, 88);
            this.bookFlightButton.Name = "bookFlightButton";
            this.bookFlightButton.Size = new System.Drawing.Size(75, 23);
            this.bookFlightButton.TabIndex = 4;
            this.bookFlightButton.Text = "Book Flight";
            this.bookFlightButton.UseVisualStyleBackColor = true;
            this.bookFlightButton.Click += new System.EventHandler(this.bookFlightButton_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.summaryLabel.Location = new System.Drawing.Point(33, 177);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(231, 23);
            this.summaryLabel.TabIndex = 5;
            // 
            // AirlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 224);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.bookFlightButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromListBox);
            this.Name = "AirlineForm";
            this.Text = "Airline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Button bookFlightButton;
        private System.Windows.Forms.Label summaryLabel;
    }
}

