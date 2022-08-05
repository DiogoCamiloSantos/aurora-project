using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace ProjetoAurora.Apresentacao.Common.HttpClient
{
    public class ApiServiceClient
    {
        public T ObterResponse<T>(object prObjeto, string prUrl, Method prMethod)
        {
            string response = string.Empty;
            string JsonObject = JsonConvert.SerializeObject(prObjeto);

            using (WebClient wc = new WebClient())
            {
                var lMethod = prMethod.ToString();
                wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                wc.Encoding = Encoding.UTF8;

                try
                {
                    if (prMethod.Equals(Method.POST))
                        response = wc.UploadString(prUrl, lMethod, JsonObject);
                    else if (prMethod.Equals(Method.GET))
                        response = wc.DownloadString(prUrl);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            if (typeof(T).IsPrimitive || typeof(T).IsValueType || typeof(T) == typeof(string))
                return (T)(object)response;

            var DeserializedObject = JsonConvert.DeserializeObject<T>(response);
            return DeserializedObject;
        }

        public enum Method
        {
            POST,
            GET
        }
    }
}