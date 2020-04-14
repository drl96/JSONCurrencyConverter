using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONDemoDACL
{
    public class DataAccessClass
    {
        public string GetDataFromAPIURL(string url)
        {
            WebClient client = new WebClient();
            var rawJSONStream = client.DownloadString(url);
            
            string JSONResponse = JsonConvert.DeserializeObject(rawJSONStream).ToString();
            return JSONResponse;
        }

        //default constructor
        public DataAccessClass() { }

    }
}