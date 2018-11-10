using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Forms
{
    class RestClientImage
    {
        public string endPoint { get; set; }
        public string key { get; set; }
        public string responseType { get; set; }
        public string theUrl { get; set; }
        public HttpThings httpMethod { get; set; }

        public RestClientImage()
        {
            endPoint = string.Empty;
            theUrl = string.Empty;
            key = "https://www.pida.io/data/";
            responseType = "?format=json";
            httpMethod = HttpThings.GET; // Continuar
        }

        public ImageDetail makeRequest()
        {
            ImageDetail laImagen;
            HttpWebRequest theRequest = (HttpWebRequest)WebRequest.Create(endPoint);
            theRequest.Method = httpMethod.ToString();
            using (HttpWebResponse webResponse = (HttpWebResponse)theRequest.GetResponse()) // Error en tiempo de ejecucion
            {
                if (webResponse.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + webResponse.StatusCode.ToString());
                }
                using (Stream responseStream = webResponse.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader theReader = new StreamReader(responseStream))
                        {
                            var theResponse = theReader.ReadToEnd();
                            laImagen = JsonConvert.DeserializeObject<ImageDetail>(theResponse);
                            return laImagen;
                        }
                    }
                }
            }
            return new ImageDetail(); // Continuar si falta algo
        }
    }
}
