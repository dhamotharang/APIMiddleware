using System;
using System.Xml.Linq;
using APIMIDDLEWARE.Services.Interfaces;
using APIMIDDLEWARE.SharedModels;
using APIMIDDLEWARE.Triggers.Rest;
using APIMIDDLEWARE.Triggers.Soap;
using APIMIDDLEWARE.Triggers.Soap.Model;

namespace APIMIDDLEWARE.Services
{
    public class IncidentService : IIncidentService
    {
        public Incident GetIncident(string ticketNumber)
        {
            var restClient = new Triggers.Rest.IncidentHandler();
            return restClient.GetIncidentObject(ticketNumber);
        }

        public Object CreateIncident(string ServiceType, string Description, string CustomerMailId, string CRMID, string SPOC)
        {
            var restClient = new Triggers.Rest.IncidentHandler();
            var userHandler = new UserDetailsHandler();
            var RaiseUser = UserDetailsHandler.ConvertFormToObject(userHandler.GetUserDetailByEmailAddress(CustomerMailId));
            return restClient.AddIncidentObject(new Incident() { Title = Description, Description = Description, RaiseUser = RaiseUser });
        }

        public Incident CreateIncident(string FirstName, string LastName, string Email, string Subject, string Description, string CRMAgentEmail, string CRMID)
        {
            var InHandler = new Triggers.Rest.IncidentHandler();
            var UsrHandler = new UserDetailsHandler();
            var RaiseUser = UserDetailsHandler.ConvertFormToObject(UsrHandler.GetUserDetailByEmailAddress(CRMAgentEmail));
            return InHandler.AddIncidentObject(new Incident()
            {
                Title = Subject,
                Description = Description,
                RaiseUser = RaiseUser,
                CustomerFirstName = FirstName,
                CustomerLastName = LastName,
                CustomerMailId = Email,
                CRMID = CRMID
            });

        }

        public bool UpdateIncident(string CRMID, string Status, string ResolutionRemarks, string IncidentNo)
        {
            return true;
        }

        public string UpdateIncident(string IncidentStatus, string CRM_IncidentRefNumber, string SDC_IncidentResolution_Remarks, string Agent_EmailID, string Ticket_Number)
        {
            var InHandler = new Triggers.Soap.IncidentHandler();
            CRMIncident incident = new CRMIncident()
            {
                IncidentStatus = IncidentStatus,
                CRM_IncidentRefNumber = CRM_IncidentRefNumber,
                SDC_IncidentResolution_Remarks = SDC_IncidentResolution_Remarks,
                Agent_EmailID = Agent_EmailID,
                Ticket_Number = Ticket_Number
            };

            return InHandler.UpdateIncident(incident); 
        }
    }
}

