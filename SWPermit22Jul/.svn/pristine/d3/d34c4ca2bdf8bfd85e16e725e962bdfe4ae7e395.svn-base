using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SidewalkPermitWPF.Helper
{
    public static class HelperClass
    {
        public static readonly string BaseUri = ConfigurationManager.AppSettings["BaseUri"].ToString();

        public static async Task<T> GetResponse<T>(T model,string endPoint)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(model));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = await client.GetAsync(BaseUri + endPoint);
                var response= JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
                return response;
            }
        }

        public static async Task<T> PostResponse<T>(T model, string endPoint)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(model));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = await client.PostAsync(BaseUri + endPoint,content);
                var response = JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
                return response;
            }
        }
    }
}
