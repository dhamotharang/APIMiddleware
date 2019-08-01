using APIMIDDLEWARE.SharedModels;
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
        Object CreateIncident(string ServiceType, string Description, string CustomerMailId, string CRMID, string SPOC);
	}
}
