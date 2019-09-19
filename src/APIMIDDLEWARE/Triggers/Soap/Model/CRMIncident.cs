using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Soap.Model
{
    public class CRMIncident
    {
        public string IncidentStatus { get; set; }
        public string CRM_IncidentRefNumber { get; set; }
        public string SDC_IncidentResolution_Remarks { get; set; }
        public string Agent_EmailID { get; set; }
        public string Ticket_Number { get; set; }
    }
}
