using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p18_Currency_Converter
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void FormConverter_Load(object sender, EventArgs e)
        {
            this.comboBoxCrrncy.SelectedItem = "EUR" ;
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void comboBoxCrrncy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void ConvertCurrency()
        {
            var originalAmount = this.numericUpDownAmount.Value;
            var convertedAmount = originalAmount;
            if (this.comboBoxCrrncy.SelectedItem.ToString() == "EUR")
{
                convertedAmount = originalAmount / 1.95583m;
            }
else if (this.comboBoxCrrncy.SelectedItem.ToString() == "USD")
{
                convertedAmount = originalAmount/1.80810m;
            }
else if (this.comboBoxCrrncy.SelectedItem.ToString() == "GBP")
{
                convertedAmount = originalAmount/2.54990m;
            }
            this.labelResult.Text = originalAmount + " лв. = " +
            Math.Round(convertedAmount, 2) + " " +this.comboBoxCrrncy.SelectedItem;
        }

    }
}
