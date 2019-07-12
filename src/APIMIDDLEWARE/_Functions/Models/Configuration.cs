using APIMIDDLEWARE._Functions.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE._Functions.Models
{
    public class Configuration
    {
        private static Configuration settings;
        public static Configuration Current
        {
            get
            {
                if (settings is null)
                {
                    try
                    {
                        var config = new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile("customsettings.json").Build();

                        settings = new Configuration();
                        config.GetSection("APIConfiguration").Bind(settings);
                    }
                    catch { }
                    settings.RestClient.ClientUrl = !settings.RestClient.ClientUrl.EndsWith("/") ? settings.RestClient.ClientUrl + "/" : settings.RestClient.ClientUrl;
                    settings.SoapClient.ClientUrl = !settings.SoapClient.ClientUrl.EndsWith("/") ? settings.SoapClient.ClientUrl + "/" : settings.SoapClient.ClientUrl;
                }
                return settings;
            }
        }

        public RestClient RestClient { get; set; }
        public SoapClient SoapClient { get; set; }
    }

    public class RestClient
    {
        public string ClientUrl { get; set; }
        public BasicCredential BasicAuthInfo { get; set; }
        public string LifeCycleName { get; set; }
    }

    public class SoapClient
    {
        public string ClientUrl { get; set; }
    }
}
