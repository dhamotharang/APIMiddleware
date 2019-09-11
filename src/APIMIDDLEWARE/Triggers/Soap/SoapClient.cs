using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMIDDLEWARE._Functions.Models;

namespace APIMIDDLEWARE.Triggers.Soap
{
    public class SoapClient
    {
        protected string ClientUrl => $"{Configuration.Current.SoapClient.ClientUrl}api/";
    }
}
