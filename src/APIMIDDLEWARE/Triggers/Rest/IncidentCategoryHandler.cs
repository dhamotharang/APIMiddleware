using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class IncidentCategoryHandler : RestClient
    {
        public IncidentCategoryHandler() { RequestClassName = "IncidentManagement.Category"; }

        public FormGet.MainForm GetCategoryByGuid(string categoryGuid)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}form?v={APIVersion}&class_name={RequestClassName}&key={categoryGuid}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<FormGet.MainForm>(requestInfo);
        }

        public FormGet.MainForm GetCategory(string name)
        {
            var result = GetCategoryListByName(name);
            if (result != null && result.DataRows != null && result.DataRows.Length == 1)
                return GetCategoryByGuid(result.DataRows[0].Key);
            return null;
        }

        public QueryGet.MainQuery GetCategoryListByName(string name)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&cns=Title-l-0&c0=%{Common.ConvertToQueryString(name)}%",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
        }
    }
}
