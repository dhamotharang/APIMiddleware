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

        public Object CreateIncident(string ServiceType, string Description, string CustomerMailId, string CRMID, string SPOC)
        {
            var restClient = new IncidentHandler();
            var userHandler = new UserDetailsHandler();
            var RaiseUser = UserDetailsHandler.ConvertFormToObject(userHandler.GetUserDetailByEmailAddress(CustomerMailId));
            return restClient.AddIncidentObject(new Incident() { Title = Description, Description = Description, RaiseUser = RaiseUser });
        }
    }
}

