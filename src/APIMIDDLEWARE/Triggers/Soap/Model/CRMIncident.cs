using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Soap.Model
{
    public class CRMIncident
    {
        public string Status { get; set; }
        public string CRMID { get; set; }
        public string ResolutionRemarks { get; set; }
        public string Email { get; set; }
        public string TicketNumber { get; set; }
    }
}
