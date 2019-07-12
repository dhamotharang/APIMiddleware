using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using APIMIDDLEWARE._Functions.Models;
using System.Xml;
using Newtonsoft.Json;

namespace APIMIDDLEWARE._Functions
{
    public class CustomWebRequest
    {
        public static T Send<T>(WebRequestInfo rqi)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(Send(rqi));
            }
            catch { }
            return default(T);
        }
        public static string Send(WebRequestInfo rqi)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            int trialCount = 0;
            string responseResult = string.Empty;
            HttpWebRequest httpWebRequest = null;
            HttpStatusCode statusCode = HttpStatusCode.NotFound;

            try
            {
                do
                {
                    httpWebRequest = (HttpWebRequest)WebRequest.Create(rqi.RequestUrl);
                    httpWebRequest.Method = rqi.RequestMethod.ToValue();
                    httpWebRequest.ContentType = rqi.DataType.ToValue();

                    if (rqi.Credential != null)
                    {
                        var bytes = Encoding.UTF8.GetBytes($"{rqi.Credential.Username}:{rqi.Credential.Password}");
                        httpWebRequest.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(bytes)}");
                    }

                    if (!string.IsNullOrEmpty(rqi.RequestData))
                    {
                        switch (rqi.Protocol)
                        {
                            case WebRequestInfo.WebServiceType.REST:
                                byte[] ByteArray = Encoding.UTF8.GetBytes(rqi.RequestData);
                                httpWebRequest.ContentLength = ByteArray.Length;
                                using (Stream stream = httpWebRequest.GetRequestStream())
                                {
                                    stream.Write(ByteArray, 0, ByteArray.Length);
                                }
                                break;
                            case WebRequestInfo.WebServiceType.SOAP:
                                XmlDocument soapEnvelopeDocument = new XmlDocument();
                                soapEnvelopeDocument.LoadXml(rqi.RequestData);
                                if (!string.IsNullOrEmpty(rqi.SoapAction))
                                    httpWebRequest.Headers.Add("SOAPAction", rqi.SoapAction);
                                using (Stream stream = httpWebRequest.GetRequestStream())
                                {
                                    soapEnvelopeDocument.Save(stream);
                                }
                                break;
                        }
                    }

                    IAsyncResult asyncResult = httpWebRequest.BeginGetResponse(null, null);
                    asyncResult.AsyncWaitHandle.WaitOne();

                    using (WebResponse webResponse = httpWebRequest.EndGetResponse(asyncResult))
                    {
                        using (StreamReader rd = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseResult = rd.ReadToEnd();
                        }
                        statusCode = ((HttpWebResponse)webResponse).StatusCode;
                    }

                    trialCount++;
                }
                while (statusCode != HttpStatusCode.OK && trialCount < 3);
            }
            catch { }
            return responseResult;
        }

        public static string ObjectToJsonString(object obj) => JsonConvert.SerializeObject(obj);

        // // Not efficient
        //public static string GenerateRequestData(Parameters[] parameters)
        //{
        //    StringBuilder ParamData = new StringBuilder();
        //    if (parameters != null)
        //    {
        //        for (int i = 0; i <= parameters.Length - 1; i++)
        //        {
        //            if (!string.IsNullOrEmpty(parameters[i].Key))
        //            {
        //                ParamData.Append(parameters[i].Key + "=" + parameters[i].Value);
        //                if (i != parameters.Length - 1)
        //                    ParamData.Append("&");
        //            }
        //        }
        //    }
        //    return ParamData.ToString();
        //}

        //public class Parameters
        //{
        //    public string Key { get; set; }
        //    public object Value { get; set; }
        //}
    }
}
