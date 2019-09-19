using APIMIDDLEWARE.SharedModels;
using APIMIDDLEWARE.Triggers.Soap.Model;
using System;
using System.ServiceModel;

namespace APIMIDDLEWARE.Services.Interfaces
{
    [ServiceContract]
	public interface IIncidentService
	{
		[OperationContract]
		Incident GetIncident(string ticketNumber);
        [OperationContract]
        Incident CreateIncident(string FirstName, string LastName, string Email, string Subject, string Description, string CRMAgentEmail, string CRMID);
        [OperationContract]
        string UpdateIncident(string CRM_IncidentRefNumber, string IncidentStatus, string SDC_IncidentResolution_Remarks, string Agent_EmailID, string Ticket_Number);
    }
}
