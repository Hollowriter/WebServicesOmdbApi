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
    public enum HttpThings
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClientClass
    {
        public string endPoint { get; set; }
        public string key { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string year { get; set; }
        public HttpThings httpMethod { get; set; }

        public RestClientClass()
        {
            endPoint = string.Empty;
            key = "http://www.omdbapi.com/?apikey=b509d3ec&";
            httpMethod = HttpThings.GET;
        }

        public Movie makeRequest()
        {
            // var theResponse = string.Empty;
            Movie laPelicula; // No importa que sea una serie
            HttpWebRequest theRequest = (HttpWebRequest)WebRequest.Create(endPoint);
            theRequest.Method = httpMethod.ToString();
            using (HttpWebResponse webResponse = (HttpWebResponse)theRequest.GetResponse())
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
                            laPelicula = JsonConvert.DeserializeObject<Movie>(theResponse); // Revisar deserealizacion
                            return laPelicula;
                        }
                    }
                }
            }
            return new Movie();
        }
    }
}
