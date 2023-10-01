/*
 * Computer Cost
 * Pawelski
 * 10/1/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Run the program a few times to familiarize yourself with
 * the code and how the program works. Once you are comfortable
 * with the code, consider the following questions...
 * 1. Is there any difference between the code for a radio button
 *    and a checkbox?
 * 2. Can checkboxes be inside a group box?
 * 3. Are there any events associated with radio buttons and checkboxes?
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

namespace ComputerCost
{
    public partial class ComputerCostForm : Form
    {
        public ComputerCostForm()
        {
            InitializeComponent();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            const double DELUXE_COST = 1000, SUPER_COST = 1500,
                VIDEO_CARD_COST = 200, MODEM_COST = 30, MEMORY_COST = 120;
            double totalCost = 0.0;

            if (deluxeRadioButton.Checked)
            {
                totalCost += DELUXE_COST;
            }
            else if (superRadioButton.Checked)
            {
                totalCost += SUPER_COST;
            }

            if (videoCardCheckBox.Checked)
            {
                totalCost += VIDEO_CARD_COST;
            }
            if (wifiCheckBox.Checked)
            {
                totalCost += MODEM_COST;
            }
            if (memoryCheckBox.Checked)
            {
                totalCost += MEMORY_COST;
            }

            totalLabel.Text = "$" + totalCost;
        }
    }
}
