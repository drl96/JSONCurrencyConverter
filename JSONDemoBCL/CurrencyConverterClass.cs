using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONDemoBCL
{
    public class CurrencyConverterClass
    {
        //Private Variables:
        private double USAmt = 0.0; 
        private double convertedAmount = 0.0;
        private double conversionRate = 0.0;
     

        //Public Interface methods
        public void setValues(double Amt, double xchangeRate)
        {
            USAmt = Amt;
            conversionRate = xchangeRate;
        }
        public void ConvertCurrency()
        {
            convertedAmount = USAmt * conversionRate;

        }
        public double getConvertedValue()
        {
            return Math.Round(convertedAmount,2);
        }

    }
}
