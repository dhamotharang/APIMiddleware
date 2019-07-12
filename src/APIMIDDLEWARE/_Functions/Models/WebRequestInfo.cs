using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE._Functions.Models
{
    public class WebRequestInfo
    {
        public enum WebServiceType { REST, SOAP }
        public WebServiceType Protocol { get; set; }
        public string RequestUrl { get; set; }
        public RequestType RequestMethod { get; set; }
        public ContentType DataType { get; set; }
        public string RequestData { get; set; }
        public BasicCredential Credential { get; set; }
        public string SoapAction { get; set; }

        public WebRequestInfo(WebServiceType webServiceType, string requestUrl,
            RequestType? requestType = null, ContentType? dataType = null,
            string requestData = "", BasicCredential basicCredential = null, 
            string soapAction = "")
        {
            Protocol = webServiceType;
            RequestUrl = requestUrl;

            switch (webServiceType)
            {
                case WebServiceType.REST:
                    RequestMethod = requestType ?? RequestType.GET;
                    DataType = dataType ?? ContentType.TEXT;
                    break;
                case WebServiceType.SOAP:
                    RequestMethod = (requestType.HasValue && (requestType == RequestType.GET || requestType == RequestType.POST)) ? requestType.Value : RequestType.POST;
                    DataType = dataType ?? ContentType.XML;
                    SoapAction = soapAction;
                    break;
            }
            RequestData = requestType == RequestType.GET ? string.Empty : requestData;
            Credential = basicCredential;
        }
    }
}
