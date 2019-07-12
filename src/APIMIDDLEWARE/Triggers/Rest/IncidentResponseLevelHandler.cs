using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class IncidentResponseLevelHandler : RestClient
    {
        public IncidentResponseLevelHandler() { RequestClassName = "Lifecycle.ResponseLevel"; }

        public FormGet.MainForm GetResponseLevelByGuid(string responseLevelGuid)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}form?v={APIVersion}&class_name={RequestClassName}&key={responseLevelGuid}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<FormGet.MainForm>(requestInfo);
        }

        public FormGet.MainForm GetResponseLevel(string name)
        {
            var result = GetResponseLevelListByName(name);
            if (result != null && result.DataRows != null && result.DataRows.Length == 1)
                return GetResponseLevelByGuid(result.DataRows[0].Key);
            return null;
        }

        public QueryGet.MainQuery GetResponseLevelListByName(string name)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&cns=Title-l-0&c0=%{Common.ConvertToQueryString(name)}%",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
        }

    }
}
