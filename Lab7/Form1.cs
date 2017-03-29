// Colin Phelps
// Lab 7
// 3/31/15
// CIS199-01
// This program takes the distance entered from a textbox and outputs the correct price for a bus ride of that distance.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Precondition: miles >= 0
        // Postcondition: The distance is matched with a price range and the correct price is displayed
        private void button1_Click(object sender, EventArgs e)
        {
            double miles;// Variable to hold the miles entered into the milesTextbox
            double price = 0;// variable to hold the 

            ushort[] distanceLowerLimit = { 0, 100, 300, 500 };// Array to hold the lower limits of each distance group
            double[] prices = { 25.00, 40.00, 55.00, 70.00 };// Array to hold the the price for each tier

            int sub =distanceLowerLimit.Length - 1;// Variable to hold the element number for the arrays

            if ((double.TryParse(milesTextbox.Text, out miles)) && (miles >= 0))
            {
                while (sub >= 0 && miles < distanceLowerLimit[sub])
                    sub--;

                price = prices[sub];
            }
            else 
            {
                // Displays an error message box if a valid number is not entered
                MessageBox.Show("Please enter a valid distance in miles");
            }

            // Assigns the correct price to the price variable and displays the price in the correct label
            
            priceLabel.Text = price.ToString("c");

        }
    }
}
