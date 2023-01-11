/*
 * Select Colors
 * 1/11/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program a few times to familiarize yourself with
 * the code and how the program works. Once you are comfortable
 * with the code, consider the following questions...
 * 1. What property is used to select a radio button initially?
 * 2. What kind of values does whiteForeRadioButton.Checked report? What
 *    does each mean?
 * 3. When are the colors actually applied to the label? Why?
 * 
 * You may have noticed that blue does not work for either foreground
 * or background color. Modify the program so that you can select blue.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectColors
{
    public partial class SelectColorsForm : Form
    {
        public SelectColorsForm()
        {
            InitializeComponent();
        }

        private void applyColorButton_Click(object sender, EventArgs e)
        {
            if(whiteForeRadioButton.Checked)
            {
                outputLabel.ForeColor = Color.White;
            }
            else if (yellowForeRadioButton.Checked)
            {
                outputLabel.ForeColor = Color.Yellow;
            }
            else if (redForeRadioButton.Checked)
            {
                outputLabel.ForeColor = Color.Red;
            }

            if (whiteBackRadioButton.Checked)
            {
                outputLabel.BackColor = Color.White;
            }
            else if (yellowBackRadioButton.Checked)
            {
                outputLabel.BackColor = Color.Yellow;
            }
            else if (redBackRadioButton.Checked)
            {
                outputLabel.BackColor = Color.Red;
            }
        }
    }
}
