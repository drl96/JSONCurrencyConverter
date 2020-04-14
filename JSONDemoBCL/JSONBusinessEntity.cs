using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONDemoBCL
{
    public class JSONBusinessEntityClass
    {
        private string date;
        private Dictionary<string, double> rates;
        private string baseCurr;

        public string Date { get => date; set => date = value; }
        public Dictionary<string, double> Rates { get => rates; set => rates = value; }
        public string BaseCurr { get => baseCurr; set => baseCurr = value; }


        //constructor
        public JSONBusinessEntityClass() { }
    }

}
