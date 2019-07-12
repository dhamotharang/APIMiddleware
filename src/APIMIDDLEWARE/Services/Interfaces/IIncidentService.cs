using APIMIDDLEWARE.SharedModels;
using System.ServiceModel;

namespace APIMIDDLEWARE.Services.Interfaces
{
    [ServiceContract]
	public interface IIncidentService
	{
		[OperationContract]
		Incident GetIncident(string ticketNumber);
	}
}
