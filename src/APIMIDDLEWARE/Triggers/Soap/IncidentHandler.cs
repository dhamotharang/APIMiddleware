using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using APIMIDDLEWARE.Triggers.Soap.Model;

namespace APIMIDDLEWARE.Triggers.Soap
{
    public class IncidentHandler : SoapClient
    {
        public string UpdateIncident(CRMIncident incident)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.SOAP,
                $"{ClientUrl}", RequestType.POST, ContentType.XML, CustomWebRequest.ObjectToXML(incident), null, string.Empty);
            return CustomWebRequest.Send(requestInfo);
        }
    }
}
