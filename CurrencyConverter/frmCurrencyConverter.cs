using JSONDemoBCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JSONDemoBCL
{
    public partial class frmCurrencyConverter: Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        Dictionary<string, double> ratesDict;
        double xchangeRate;
    
        private void frmCurrencyConverter_Load(object sender, EventArgs e)
        {
            string strURL = "https://api.exchangeratesapi.io/latest?base=USD";
            BusinessLogicClass myBCL = new BusinessLogicClass();

            Dictionary<string, double> ratesDict = myBCL.RequestAPIDataFromUrl(strURL);
            ratesBindingSource.DataSource = ratesDict;
            keyListBox.SelectedIndex = -1;
            keyListBox_SelectedIndexChanged(null, null);
        }

        private void keyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keyListBox.SelectedIndex != -1)
            {
                xchangeRate = (double)(keyListBox.SelectedValue);
                lblConvertedAmount.Text = String.Empty;
                lblExchangeRate.Text = xchangeRate.ToString("n5");
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double amtToConvert = double.Parse(txtAmtToConvert.Text);
            CurrencyConverterClass aConverter = new CurrencyConverterClass();
            aConverter.setValues(amtToConvert, xchangeRate);
            aConverter.ConvertCurrency();
            lblConvertedAmount.Text = aConverter.getConvertedValue().ToString("n2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

       
    }
}
