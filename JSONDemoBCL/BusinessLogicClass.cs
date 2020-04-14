using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSONDemoDACL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONDemoBCL
{
    public class BusinessLogicClass
    {

        public Dictionary<string, double> RequestAPIDataFromUrl(string url)
        {
            DataAccessClass myDAC = new DataAccessClass();
            string strJSONResponse = myDAC.GetDataFromAPIURL(url);

            JObject parent = JObject.Parse(strJSONResponse);
            var rates = parent.Value<JObject>("rates").Properties();
            Dictionary<string, double> ratesDict = rates.ToDictionary(x => x.Name,  y => (double)y.Value);
            return ratesDict;
        }

        public BusinessLogicClass()
        {

        }
    }
}