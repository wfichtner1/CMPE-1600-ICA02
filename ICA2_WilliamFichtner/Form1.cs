using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA2_WilliamFichtner
{
    public partial class Form1 : Form
    {
        bool check1 = false;
        bool check2 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UI_CalculateButton_Click(object sender, EventArgs e)
        {
            double cost = 0.0;
            double numberPurchased = 0.0;
            double subtotal = 0.0;
            double gstAmount = 0.0;
            double total = 0.0;
            const double gst = 0.05;

            if ((double.TryParse(UI_CostBox.Text, out cost)) && (double.TryParse(UI_PurchaseBox.Text, out numberPurchased)))
            {
                subtotal = cost * numberPurchased;
                UI_SubtotalAmountLabel.Text = subtotal.ToString("C");
                gstAmount = subtotal * gst;
                UI_GSTAmountLabel.Text = gstAmount.ToString("C");
                total = subtotal + gstAmount;
                UI_TotalAmountLabel.Text = total.ToString("C");
            }
            else
            {
                MessageBox.Show("You must enter valid amounts for each entry.", "ICA02", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UI_CalculateButton.Enabled = false;
            check1 = false;
            check2 = false;
        }

        private void UI_CostBox_TextChanged(object sender, EventArgs e)
        {
            UI_SubtotalAmountLabel.Text = "$0.00";
            UI_GSTAmountLabel.Text = "$0.00";
            UI_TotalAmountLabel.Text = "$0.00";
            check1 = true;
            if ((check1 == true) && (check2 == true))
            {
                UI_CalculateButton.Enabled = true;
            }
        }

        private void UI_PurchaseBox_TextChanged(object sender, EventArgs e)
        {
            UI_SubtotalAmountLabel.Text = "$0.00";
            UI_GSTAmountLabel.Text = "$0.00";
            UI_TotalAmountLabel.Text = "$0.00";
            check2 = true;
            if ((check1 == true) && (check2 == true))
            {
                UI_CalculateButton.Enabled = true;
            }
        }
    }
}
