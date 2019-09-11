using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.SharedModels
{
    [DataContract]
    public class Incident
    {
        public const string FormItemGroupLabel = "Incident Details";

        [DataMember]
        public string Key { get; set; } // ->Key
        [DataMember]
        public IUser RaiseUser { get; set; } // RaiseUser
        [DataMember]
        public IOffice ActualLocation { get; set; }
        [DataMember]
        public string CustomerFirstName { get; set; }
        [DataMember]
        public string CustomerLastName { get; set; }
        [DataMember]
        public string CustomerMailId { get; set; }
        [DataMember]
        public string CRMID { get; set; }
        [DataMember]
        public string CurrentAssignAnalyst { get; set; }
        [DataMember]
        public string Title { get; set; } // Title
        [DataMember]
        public string Description { get; set; } // Description
        [DataMember]
        public ICategory Category { get; set; }
        [DataMember]
        public IUrgency Urgency { get; set; }
        [DataMember]
        public ISource Source { get; set; }
        [DataMember]
        public IResponseLevel ResponseLevel { get; set; }
        [DataMember]
        public string FloorNumber { get; set; } // _FloorNumber

        [DataMember]
        public IAssignedDetail AssignmentDetail { get; set; }
        [DataMember]
        public IInformation Information { get; set; }
        [DataMember]
        public IAdministratorJob Administrator { get; set; }

        [DataContract]
        public class IUser
        {
            public const string FormItemGroupLabel = "Raise User Details";

            [DataMember]
            public string Key { get; set; } // RaiseUser->Value
            [DataMember]
            public string Name { get; set; } // RaiseUser->DisplayText
            [DataMember]
            public string LoginId { get; set; } // RaiseUser.Name
            [DataMember]
            public string Email { get; set; } // RaiseUser.EMailAddress
            [DataMember]
            public string IPPhone { get; set; } // RaiseUser._IPPhone
            [DataMember]
            public IOffice Office { get; set; } // _Office
            [DataMember]
            public IGroup Group { get; set; } // _Group
            [DataMember]
            public ISection Section { get; set; } // _Section2
            [DataMember]
            public IState State { get; set; } // _State
        }

        [DataContract]
        public class ISimplifiedUser
        {
            [DataMember]
            public string Key { get; set; } // []->Value
            [DataMember]
            public string Name { get; set; } // []->DisplayText
        }

        [DataContract]
        public class IOffice
        {
            public const string FormItemGroupLabel = "Actual Location:";
            [DataMember]
            public string Key { get; set; } //_Office1->Value
            [DataMember]
            public string Name { get; set; } //_Office1->DisplayText
        }

        [DataContract]
        public class IGroup
        {
            [DataMember]
            public string Key { get; set; }
            [DataMember]
            public string Name { get; set; }
        }

        [DataContract]
        public class ISection
        {
            [DataMember]
            public string Key { get; set; }
            [DataMember]
            public string Name { get; set; }
        }

        [DataContract]
        public class IState
        {
            [DataMember]
            public string Key { get; set; }
            [DataMember]
            public string Name { get; set; }
        }

        [DataContract]
        public class ICategory
        {
            [DataMember]
            public string Key { get; set; } //Category->Value
            [DataMember]
            public string Name { get; set; } //Category->DisplayText
        }

        [DataContract]
        public class IUrgency
        {
            [DataMember]
            public string Key { get; set; } //_IncidentUrgency->Value
            [DataMember]
            public string Name { get; set; } //_IncidentUrgency->DisplayText
        }

        [DataContract]
        public class ISource
        {
            [DataMember]
            public string Key { get; set; } //_IncidentSource->Value
            [DataMember]
            public string Name { get; set; } //_IncidentSource->DisplayText
        }

        [DataContract]
        public class IResponseLevel
        {
            [DataMember]
            public string Key { get; set; } //ResponseLevel->Value
            [DataMember]
            public string Name { get; set; } //ResponseLevel->DisplayText
        }

        [DataContract]
        public class IAssignedDetail
        {
            public const string FormItemGroupLabel = "Current Assignment Details";

            [DataMember]
            public string Analyst { get; set; } //_CurrentAssignedAnalyst
            [DataMember]
            public string Group { get; set; } //_CurrentAssignedGroup
        }

        [DataContract]
        public class IInformation
        {
            public const string FormItemGroupLabel = "Information";

            [DataMember]
            public string TicketNumber { get; set; } //_TicketNumber
            [DataMember]
            public IStatus Status { get; set; }
            [DataMember]
            public string CreatedDate { get; set; } //CreationDate
            [DataMember]
            public ISimplifiedUser CreatedBy { get; set; } //CreationUser
            [DataMember]
            public string AcknowledgedDate { get; set; } //_AcknowledgedDate
            [DataMember]
            public ISimplifiedUser AcknowledgedBy { get; set; } //_AcknowledgedBy
            [DataMember]
            public string ModifiedDate { get; set; } //LastUpdate
            [DataMember]
            public ISimplifiedUser ModifiedBy { get; set; } //LastUpdateUser
            [DataMember]
            public string ResolvedDate { get; set; } //_ResolvedDate
            [DataMember]
            public ISimplifiedUser ResolvedBy { get; set; } //_ResolvedBy
            [DataMember]
            public string ResolutionRemarks { get; set; } //_ResolutionRemarks
            [DataMember]
            public string ClosedByStr { get; set; } //_ClosedByStr
        }

        [DataContract]
        public class IStatus
        {
            [DataMember]
            public string Key { get; set; } //Status->Value
            [DataMember]
            public string Name { get; set; } //Status->DisplayText
        }

        [DataContract]
        public class IAdministratorJob
        {
            public const string FormItemGroupLabel = "Administrator";

            [DataMember]
            public bool SurveyDone { get; set; } //_SurveyDone
            [DataMember]
            public string TriggerFloorNumber { get; set; } //_TriggerFloorNumber
        }
    }
}
