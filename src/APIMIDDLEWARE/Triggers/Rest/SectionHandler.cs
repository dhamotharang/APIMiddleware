using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class SectionHandler : RestClient
    {
        public SectionHandler() { RequestClassName = "System._Section2"; }

        public QueryGet.MainQuery GetSectionListByName(string name)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&cns=_Title-l-0&c0=%{Common.ConvertToQueryString(name)}%",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
        }
    }
}
