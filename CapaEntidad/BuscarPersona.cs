using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace CapaEntidad
{
     public class BuscarPersona
    {
        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Brave/1.47.171(Windows NT 6.1;WOW64;rv:23.0)Gecko/20100101 firefox/23.0";
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHtttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStrem = myHtttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStrem);
            string datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            dynamic data = JsonConvert.DeserializeObject(datos);
            return data;
        }
    }
}
