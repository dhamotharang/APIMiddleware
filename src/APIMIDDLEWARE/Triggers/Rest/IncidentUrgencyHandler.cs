using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class IncidentUrgencyHandler : RestClient
    {
        public IncidentUrgencyHandler() { RequestClassName = "IncidentManagement._IncidentUrgency"; }

        public FormGet.MainForm GetUrgencyByGuid(string urgencyGuid)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}form?v={APIVersion}&class_name={RequestClassName}&key={urgencyGuid}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<FormGet.MainForm>(requestInfo);
        }

        public FormGet.MainForm GetUrgency(string name)
        {
            var result = GetUrgencyListByName(name);
            if (result != null && result.DataRows != null && result.DataRows.Length == 1)
                return GetUrgencyByGuid(result.DataRows[0].Key);
            return null;
        }

        public QueryGet.MainQuery GetUrgencyListByName(string name)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&cns=_Title-l-0&c0=%{Common.ConvertToQueryString(name)}%",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
        }
    }
}
