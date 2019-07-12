using System;
using System.Xml.Linq;
using APIMIDDLEWARE.Services.Interfaces;
using APIMIDDLEWARE.SharedModels;
using APIMIDDLEWARE.Triggers.Rest;

namespace APIMIDDLEWARE.Services
{
    public class IncidentService : IIncidentService
    {
        public Incident GetIncident(string ticketNumber)
        {
            var restClient = new IncidentHandler();
            return restClient.GetIncidentObject(ticketNumber);
        }
    }
}

