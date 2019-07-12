using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class IncidentSourceHandler : RestClient
    {
        public IncidentSourceHandler() { RequestClassName = "IncidentManagement._IncidentSource"; }

        public FormGet.MainForm GetSourceByGuid(string urgencyGuid)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}form?v={APIVersion}&class_name={RequestClassName}&key={urgencyGuid}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<FormGet.MainForm>(requestInfo);
        }

        public FormGet.MainForm GetSource(string name)
        {
            var result = GetSourceListByName(name);
            if (result != null && result.DataRows != null && result.DataRows.Length == 1)
                return GetSourceByGuid(result.DataRows[0].Key);
            return null;
        }

        public QueryGet.MainQuery GetSourceListByName(string name)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&cns=_Title-l-0&c0=%{Common.ConvertToQueryString(name)}%",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
        }
    }
}
