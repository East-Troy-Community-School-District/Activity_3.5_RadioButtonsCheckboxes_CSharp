/*
 * Airline
 * Pawelski
 * 10/1/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Run the program a few times to familiarize yourself with
 * the code and how the program works. Once you are comfortable
 * with the code, consider the following questions...
 * 1. How is the code more condensed when compared to the code for
 *    radio buttons?
 * 2. Is there an alternative way to write this code?
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

namespace AirLine
{
    public partial class AirlineForm : Form
    {
        public AirlineForm()
        {
            InitializeComponent();
        }

        private void bookFlightButton_Click(object sender, EventArgs e)
        {
            string source, destination;

            source = fromListBox.Text;
            destination = toListBox.Text;

            summaryLabel.Text = "You are flying from " + source
                + " to " + destination + ".";
        }
    }
}
