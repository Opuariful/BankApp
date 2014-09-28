using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankapps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
            double interst = 0.0;
            double TimeInYear=Convert.ToDouble(TimeInYeartextBox.Text);
            double balance = Convert.ToDouble(BalancetextBox.Text);
            if (bankNameComboBox.Text == "BRAC") {
                interst = TimeInYear * (balance * 0.06);
                interstDisplayLabel.Text = interst.ToString();
            }
            else if (bankNameComboBox.Text == "DBBL")
            {
                interst = TimeInYear * (balance *0.07);
                interstDisplayLabel.Text = interst.ToString();
            }
            else if (bankNameComboBox.Text == "HSBC")
            {
                interst = TimeInYear * (balance * 0.08);
                interstDisplayLabel.Text = interst.ToString();
            }
        }

        private void bankNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
