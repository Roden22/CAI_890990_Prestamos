using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;
using System.Collections.Specialized;

namespace Banca.Datos
{
    public static class WebHelper
    {
        static WebClient _webClient;
        static string _rutaBase;

        static WebHelper()
        {
            _rutaBase = ConfigurationManager.AppSettings["API_URL"];

            _webClient = new WebClient
            {
                Encoding = Encoding.UTF8,
            };

            _webClient.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static string Get(string url)
        {
            string uri = _rutaBase + url;
            return _webClient.DownloadString(uri);
        }

        public static string Post(string url, NameValueCollection param)
        {
            string uri = _rutaBase + url;
            try
            {
                byte[] response = _webClient.UploadValues(uri, param);
                string r = Encoding.Default.GetString(response);
                return r;
            }
            catch (Exception)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio.\"}";
            }
        }
    }
}
