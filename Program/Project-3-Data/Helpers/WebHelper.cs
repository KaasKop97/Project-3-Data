using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Project_3_Data.Helpers
{
    public class WebHelper
    {
        private string ApiUrl = "";
        private string AuthHeaderName = "";
        private string AuthKey = "";

        public WebHelper(string ApiUrl, string AuthHeaderName = "", string AuthKey = "")
        {
            this.ApiUrl = ApiUrl;
            this.AuthHeaderName = AuthHeaderName;
            this.AuthKey = AuthKey;
        }

        public string GetData(string path = "", string parameters = "")
        {
            WebClient wc = new WebClient();
            if(this.AuthKey != "" && this.AuthHeaderName != "")
            {
                wc.Headers[this.AuthHeaderName] = this.AuthKey;
            }

            string url = this.ApiUrl + path;

            if (parameters != "")
            {
                url = this.ApiUrl + path + "?" + parameters;
            }
            //TODO: Catch errors
            string result = wc.DownloadString(url);

            return result;
        }
    }
}
