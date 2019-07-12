using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMIDDLEWARE._Functions.Models;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class RestClient
    {
        protected string ClientUrl => $"{Configuration.Current.RestClient.ClientUrl}api/";
        protected BasicCredential Credential => Configuration.Current.RestClient.BasicAuthInfo;
        protected string LifeCycleName => Configuration.Current.RestClient.LifeCycleName;
        protected string RequestClassName = "";
        protected const string APIVersion = "*";
    }
}
