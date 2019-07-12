using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class UserHandler : RestClient
    {
        public UserHandler() { RequestClassName = "System.User"; }

        private string GetUserGuidByLoginID(string loginId)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&cns=Name-e-0&c0={loginId}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            var responseData = CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
            if (responseData != null && responseData.DataRows != null && responseData.DataRows.Length == 1)
                return responseData.DataRows[0].Key;
            return string.Empty;
        }

        public FormGet.MainForm GetUserByGuid(string userGuid)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}form?v={APIVersion}&class_name={RequestClassName}&key={userGuid}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<FormGet.MainForm>(requestInfo);
        }

        public FormGet.MainForm GetUser(string loginId)
        {
            var userGuid = GetUserGuidByLoginID(loginId);
            return GetUserByGuid(userGuid);
        }

        public QueryGet.MainQuery GetUserListByName(string name)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&cns=Title-l-0&c0=%{Common.ConvertToQueryString(name)}%",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
        }
    }
}
