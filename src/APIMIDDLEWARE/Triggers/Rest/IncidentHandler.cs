using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.SharedModels;
using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class IncidentHandler : RestClient
    {
        public IncidentHandler() { RequestClassName = "IncidentManagement.Incident"; }

        private string GetIncidentGuidByTicketNumber(string ticketNumber)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&cns=_TicketNumber-e-0&c0={ticketNumber}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            var responseData = CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
            if (responseData != null && responseData.DataRows != null && responseData.DataRows.Length == 1)
                return responseData.DataRows[0].Key;
            return string.Empty;
        }

        public FormGet.MainForm GetIncidentByGuid(string incidentGuid)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}form?v={APIVersion}&class_name={RequestClassName}&key={incidentGuid}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<FormGet.MainForm>(requestInfo);
        }

        public FormGet.MainForm GetIncident(string ticketNumber)
        {
            var incidentGuid = GetIncidentGuidByTicketNumber(ticketNumber);
            return GetIncidentByGuid(incidentGuid);
        }

        public Incident GetIncidentObject(string ticketNumber)
        {
            var form = GetIncident(ticketNumber);
            return ConvertFormToObject(form);
        }

        public Incident AddIncidentObject(Incident incident)
        {
            var form = ConvertObjectToInsertionForm(incident);
            if (form != null)
            {
                var result = AddIncident(form);
                if (result != null)
                    return ConvertFormToObject(GetIncidentByGuid(result.Key));
            }
            return null;
        }

        public object UpdateIncidentObject(Incident incident)
        {
            var form = ConvertObjectToUpdationForm(incident);
            if (form != null)
            {
                var result = UpdateIncident(incident.Information.TicketNumber, form);
                if (result != null)
                    return new { ConvertFormToObject(GetIncidentByGuid(result.Key)).Information.TicketNumber };
            }
            return null;
        }

        public QueryGet.MainQuery GetIncidentListByCustomFields(CustomField customField)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?v={APIVersion}&class_name={RequestClassName}&{customField.GetFilteredQueryString()}",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            return CustomWebRequest.Send<QueryGet.MainQuery>(requestInfo);
        }

        public FormPostPatch.FormResponse AddIncident(FormPostPatch.InsertionItem item)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}form?v={APIVersion}&class_name={RequestClassName}&lifecycle_name={LifeCycleName}",
                RequestType.POST, ContentType.JSON, CustomWebRequest.ObjectToJsonString(item), Credential);
            return CustomWebRequest.Send<FormPostPatch.FormResponse>(requestInfo);
        }

        public FormPostPatch.FormResponse UpdateIncident(string ticketNumber, FormPostPatch.UpdationItem item)
        {
            var incidentGuid = GetIncidentGuidByTicketNumber(ticketNumber);
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}form?v={APIVersion}&class_name={RequestClassName}&key={incidentGuid}",
                RequestType.PATCH, ContentType.JSON, CustomWebRequest.ObjectToJsonString(item), Credential);
            return CustomWebRequest.Send<FormPostPatch.FormResponse>(requestInfo);
        }

        public class CustomField
        {
            public string TicketNumber { get; set; }
            public string Summary { get; set; }
            public string RaiseUserGuid { get; set; }
            public string CreatedStartDate { get; set; }
            public string CreatedEndDate { get; set; }
            public string CategoryGuid { get; set; }

            private bool IsEmpty()
            {
                return string.IsNullOrEmpty(TicketNumber) &&
                       string.IsNullOrEmpty(Summary) &&
                       string.IsNullOrEmpty(RaiseUserGuid) &&
                       (!Common.IsDate(CreatedStartDate) ||
                       !Common.IsDate(CreatedEndDate)) &&
                       string.IsNullOrEmpty(CategoryGuid);
            }

            private static string GetFixedFilteredText(string text, int count)
            {
                return count > 0 ? "_a_" + text : text;
            }

            private static string GetFixedFilteredValue(string text, int count)
            {
                text = Common.ConvertToQueryString(text);
                return count > 0 ? "&" + text : text;
            }

            public string GetFilteredQueryString()
            {
                if (IsEmpty()) // By default: created date set to today date
                {
                    var curDate = DateTime.Now.Date;
                    CreatedStartDate = curDate.ToString("yyyy-MM-ddTHH:mm:ss");
                    CreatedEndDate = curDate.AddDays(1).AddMilliseconds(-1).ToString("yyyy-MM-ddTHH:mm:ss");
                }
                var cnsFilterText = new StringBuilder();
                var valueFilterText = new StringBuilder();
                var filteredCount = 0;
                cnsFilterText.Append("cns=");

                if (!string.IsNullOrEmpty(TicketNumber))
                {
                    cnsFilterText.Append(GetFixedFilteredText($"_TicketNumber-l-{filteredCount}-", filteredCount));
                    valueFilterText.Append(GetFixedFilteredValue($"c{filteredCount}=%{TicketNumber}%", filteredCount));
                    filteredCount++;
                }
                if (!string.IsNullOrEmpty(Summary))
                {
                    cnsFilterText.Append(GetFixedFilteredText($"Title-l-{filteredCount}-", filteredCount));
                    valueFilterText.Append(GetFixedFilteredValue($"c{filteredCount}=%{Summary}%", filteredCount));
                    filteredCount++;
                }
                if (!string.IsNullOrEmpty(RaiseUserGuid))
                {
                    cnsFilterText.Append(GetFixedFilteredText($"RaiseUser-e-{filteredCount}-", filteredCount));
                    valueFilterText.Append(GetFixedFilteredValue($"c{filteredCount}={RaiseUserGuid}", filteredCount));
                    filteredCount++;
                }
                if (Common.IsDate(CreatedStartDate) && Common.IsDate(CreatedEndDate))
                {
                    cnsFilterText.Append(GetFixedFilteredText($"CreationDate-gte-{filteredCount}-", filteredCount));
                    valueFilterText.Append(GetFixedFilteredValue($"c{filteredCount}={CreatedStartDate}", filteredCount));
                    filteredCount++;
                    cnsFilterText.Append(GetFixedFilteredText($"CreationDate-lte-{filteredCount}-", filteredCount));
                    valueFilterText.Append(GetFixedFilteredValue($"c{filteredCount}={CreatedEndDate}", filteredCount));
                    filteredCount++;
                }
                if (!string.IsNullOrEmpty(CategoryGuid))
                {
                    cnsFilterText.Append(GetFixedFilteredText($"Category-e-{filteredCount}-", filteredCount));
                    valueFilterText.Append(GetFixedFilteredValue($"c{filteredCount}={CategoryGuid}", filteredCount));
                    filteredCount++;
                }

                return $"{cnsFilterText.ToString()}&{valueFilterText.ToString()}";
            }
        }

        public static Incident ConvertFormToObject(FormGet.MainForm incidentForm)
        {
            if (incidentForm == null) return null;
            var incident = new Incident
            {
                Key = incidentForm.Key
            };

            var userInfo = incidentForm.FormItems.Where(x => x.Label.Equals(Incident.IUser.FormItemGroupLabel)).FirstOrDefault();
            if (userInfo != null)
            {
                incident.RaiseUser = new Incident.IUser();

                var raiseUser = userInfo.FormItems.Where(x => x.FullName.Equals("RaiseUser")).FirstOrDefault();
                if (raiseUser != null)
                {
                    incident.RaiseUser.Key = raiseUser.Value;
                    incident.RaiseUser.Name = raiseUser.DisplayText;
                }

                var loginId = userInfo.FormItems.Where(x => x.FullName.Equals("RaiseUser.Name")).FirstOrDefault();
                if (loginId != null)
                    incident.RaiseUser.LoginId = loginId.Value;

                var email = userInfo.FormItems.Where(x => x.FullName.Equals("RaiseUser.EMailAddress")).FirstOrDefault();
                if (email != null)
                    incident.RaiseUser.Email = email.Value;

                var ipPhone = userInfo.FormItems.Where(x => x.FullName.Equals("RaiseUser._IPPhone")).FirstOrDefault();
                if (ipPhone != null)
                    incident.RaiseUser.IPPhone = ipPhone.Value;

                var office = userInfo.FormItems.Where(x => x.FullName.Equals("_Office")).FirstOrDefault();
                if (office != null)
                {
                    incident.RaiseUser.Office = new Incident.IOffice() { Name = office.DisplayText };

            }

            var group = userInfo.FormItems.Where(x => x.FullName.Equals("_Group")).FirstOrDefault();
                if (group != null)
                    incident.RaiseUser.Group = new Incident.IGroup() { Name = group.DisplayText };

                var section = userInfo.FormItems.Where(x => x.FullName.Equals("_Section2")).FirstOrDefault();
                if (section != null)
                    incident.RaiseUser.Section = new Incident.ISection() { Name = section.DisplayText };

                var state = userInfo.FormItems.Where(x => x.FullName.Equals("_State")).FirstOrDefault();
                if (state != null)
                    incident.RaiseUser.State = new Incident.IState { Name = state.DisplayText };
            }

            var officeInfo = incidentForm.FormItems.Where(x => x.Label.Equals(Incident.IOffice.FormItemGroupLabel)).FirstOrDefault();
            if (officeInfo != null)
            {
                var office = officeInfo.FormItems.Where(x => x.FullName.Equals("_Office1")).FirstOrDefault();
                if (office != null)
                {
                    incident.ActualLocation = new Incident.IOffice
                    {
                        Key = office.Value,
                        Name = office.DisplayText
                    };
                }
            }

            var incidentInfo = incidentForm.FormItems.Where(x => x.Label.Equals(Incident.FormItemGroupLabel)).FirstOrDefault();
            if (incidentInfo != null)
            {
                var title = incidentInfo.FormItems.Where(x => x.FullName.Equals("Title")).FirstOrDefault();
                if (title != null)
                    incident.Title = title.Value;

                var description = incidentInfo.FormItems.Where(x => x.FullName.Equals("Description")).FirstOrDefault();
                if (description != null)
                    incident.Description = description.Value;

                var category = incidentInfo.FormItems.Where(x => x.FullName.Equals("Category")).FirstOrDefault();
                if (category != null)
                {
                    incident.Category = new Incident.ICategory()
                    {
                        Key = category.Value,
                        Name = category.DisplayText
                    };
                }

                var urgency = incidentInfo.FormItems.Where(x => x.FullName.Equals("_IncidentUrgency")).FirstOrDefault();
                if (urgency != null)
                {
                    incident.Urgency = new Incident.IUrgency()
                    {
                        Key = urgency.Value,
                        Name = urgency.DisplayText
                    };
                }

                var source = incidentInfo.FormItems.Where(x => x.FullName.Equals("_IncidentSource")).FirstOrDefault();
                if (source != null)
                {
                    incident.Source = new Incident.ISource()
                    {
                        Key = source.Value,
                        Name = source.DisplayText
                    };
                }

                var responseLevel = incidentInfo.FormItems.Where(x => x.FullName.Equals("ResponseLevel")).FirstOrDefault();
                if (responseLevel != null)
                {
                    incident.ResponseLevel = new Incident.IResponseLevel()
                    {
                        Key = responseLevel.Value,
                        Name = responseLevel.DisplayText
                    };
                }

                var floorNumber = incidentInfo.FormItems.Where(x => x.FullName.Equals("_FloorNumber")).FirstOrDefault();
                if (floorNumber != null)
                    incident.FloorNumber = floorNumber.Value;
            }

            var assignmentInfo = incidentForm.FormItems.Where(x => x.Label.Equals(Incident.IAssignedDetail.FormItemGroupLabel)).FirstOrDefault();
            if (assignmentInfo != null)
            {
                incident.AssignmentDetail = new Incident.IAssignedDetail();

                var analyst = assignmentInfo.FormItems.Where(x => x.FullName.Equals("_CurrentAssignedAnalyst")).FirstOrDefault();
                if (analyst != null)
                    incident.AssignmentDetail.Analyst = analyst.Value;

                var group = assignmentInfo.FormItems.Where(x => x.FullName.Equals("_CurrentAssignedGroup")).FirstOrDefault();
                if (group != null)
                    incident.AssignmentDetail.Group = group.Value;
            }

            var information = incidentForm.FormItems.Where(x => x.Label.Equals(Incident.IInformation.FormItemGroupLabel)).FirstOrDefault();
            if (information == null) return null;
                
            incident.Information = new Incident.IInformation();

            var ticketNumber = information.FormItems.Where(x => x.FullName.Equals("_TicketNumber")).FirstOrDefault();
            if (ticketNumber != null)
                incident.Information.TicketNumber = ticketNumber.Value;

            var status = information.FormItems.Where(x => x.FullName.Equals("Status")).FirstOrDefault();
            if (status != null)
            {
                incident.Information.Status = new Incident.IStatus()
                {
                    Key = status.Value,
                    Name = status.DisplayText
                };
            }

            var createdDate = information.FormItems.Where(x => x.FullName.Equals("CreationDate")).FirstOrDefault();
            if (createdDate != null)
                incident.Information.CreatedDate = createdDate.Value;

            var createdBy = information.FormItems.Where(x => x.FullName.Equals("CreationUser")).FirstOrDefault();
            if (createdBy != null)
            {
                incident.Information.CreatedBy = new Incident.ISimplifiedUser()
                {
                    Key = createdBy.Value,
                    Name = createdBy.DisplayText
                };
            }

            var acknowledgedDate = information.FormItems.Where(x => x.FullName.Equals("_AcknowledgedDate")).FirstOrDefault();
            if (acknowledgedDate != null)
                incident.Information.AcknowledgedDate = acknowledgedDate.Value;

            var acknowledgedBy = information.FormItems.Where(x => x.FullName.Equals("_AcknowledgedBy")).FirstOrDefault();
            if (acknowledgedBy != null)
            {
                incident.Information.AcknowledgedBy = new Incident.ISimplifiedUser()
                {
                    Key = acknowledgedBy.Value,
                    Name = acknowledgedBy.DisplayText
                };
            }

            var modifiedDate = information.FormItems.Where(x => x.FullName.Equals("LastUpdate")).FirstOrDefault();
            if (modifiedDate != null)
                incident.Information.ModifiedDate = modifiedDate.Value;

            var modifiedBy = information.FormItems.Where(x => x.FullName.Equals("LastUpdateUser")).FirstOrDefault();
            if (modifiedBy != null)
            {
                incident.Information.ModifiedBy = new Incident.ISimplifiedUser()
                {
                    Key = modifiedBy.Value,
                    Name = modifiedBy.DisplayText
                };
            }

            var resolvedDate = information.FormItems.Where(x => x.FullName.Equals("_ResolvedDate")).FirstOrDefault();
            if (resolvedDate != null)
                incident.Information.ResolvedDate = resolvedDate.Value;

            var resolvedBy = information.FormItems.Where(x => x.FullName.Equals("_ResolvedBy")).FirstOrDefault();
            if (resolvedBy != null)
            {
                incident.Information.ResolvedBy = new Incident.ISimplifiedUser()
                {
                    Key = resolvedBy.Value,
                    Name = resolvedBy.DisplayText
                };
            }

            var remarks = information.FormItems.Where(x => x.FullName.Equals("_ResolutionRemarks")).FirstOrDefault();
            if (remarks != null)
                incident.Information.ResolutionRemarks = remarks.Value;

            var closedByStr = information.FormItems.Where(x => x.FullName.Equals("_ClosedByStr")).FirstOrDefault();
            if (closedByStr != null)
                incident.Information.ClosedByStr = closedByStr.Value;

            var adminInfo = incidentForm.FormItems.Where(x => x.Label.Equals(Incident.IAdministratorJob.FormItemGroupLabel)).FirstOrDefault();
            if (adminInfo != null)
            {
                incident.Administrator = new Incident.IAdministratorJob();

                var surveyDone = adminInfo.FormItems.Where(x => x.FullName.Equals("_SurveyDone")).FirstOrDefault();
                if (surveyDone != null)
                {
                    incident.Administrator.SurveyDone = surveyDone.Value.Equals("true");
                }

                var triggerFloorNumber = adminInfo.FormItems.Where(x => x.FullName.Equals("_TriggerFloorNumber")).FirstOrDefault();
                if (triggerFloorNumber != null)
                {
                    incident.Administrator.TriggerFloorNumber = triggerFloorNumber.Value;
                }
            }

            return incident;
        }

        public static FormPostPatch.InsertionItem ConvertObjectToInsertionForm(Incident incident)
        {
            if (incident == null) return null;
            var form = new FormPostPatch.InsertionItem();

            if (incident.RaiseUser != null && !string.IsNullOrEmpty(incident.RaiseUser.Key))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "RaiseUser", Value = incident.RaiseUser.Key });
            if (incident.RaiseUser.Section != null && !string.IsNullOrEmpty(incident.RaiseUser.Section.Key))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_Section", Value = incident.RaiseUser.Section.Key });
            if (incident.ActualLocation != null && !string.IsNullOrEmpty(incident.ActualLocation.Key))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_Office1", Value = incident.ActualLocation.Key });
            if (!string.IsNullOrEmpty(incident.Title))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "Title", Value = incident.Title });
            if (!string.IsNullOrEmpty(incident.Description))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "Description", Value = incident.Description });
            if (incident.Category != null && !string.IsNullOrEmpty(incident.Category.Key))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "Category", Value = incident.Category.Key });
            if (incident.Urgency != null && !string.IsNullOrEmpty(incident.Urgency.Key))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_IncidentUrgency", Value = incident.Urgency.Key });
            if (incident.Source != null && !string.IsNullOrEmpty(incident.Source.Key))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_IncidentSource", Value = incident.Source.Key });
            if (incident.ResponseLevel != null && !string.IsNullOrEmpty(incident.ResponseLevel.Key))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "ResponseLevel", Value = incident.ResponseLevel.Key });
            if (!string.IsNullOrEmpty(incident.FloorNumber))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_FloorNumber", Value = incident.FloorNumber });
            if (!string.IsNullOrEmpty(incident.CustomerFirstName))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_CustomerFirstName", Value = incident.CustomerFirstName });
            if (!string.IsNullOrEmpty(incident.CustomerLastName))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_CustomerLastName", Value = incident.CustomerLastName });
            if (!string.IsNullOrEmpty(incident.CustomerMailId))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_CustomerMailID", Value = incident.CustomerMailId });
            if (!string.IsNullOrEmpty(incident.CurrentAssignAnalyst))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_AssignedAnalystEmail", Value = incident.CurrentAssignAnalyst });
            if (!string.IsNullOrEmpty(incident.CRMID))
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_CRMID", Value = incident.CRMID });
            return form;
        }

        /** To-do: update incident info based on 'incident' object 
         * instead of the traditional api trigger ways (FormPostPatch.UpdationItem)
         * Need to figure the field used to update
        **/
        public static FormPostPatch.UpdationItem ConvertObjectToUpdationForm(Incident incident) // Depends on ticket number instead of key
        {
            if (incident == null || incident.Information == null || 
                string.IsNullOrEmpty(incident.Information.TicketNumber)) return null;

            // Temp solution - Restrict to access with static
            var incidentHandler = new IncidentHandler();

            var previousIncident = incidentHandler.GetIncidentObject(incident.Information.TicketNumber);
            if (previousIncident == null) return null;

            var form = new FormPostPatch.UpdationItem();

            if (incident.RaiseUser != null && !string.IsNullOrEmpty(incident.RaiseUser.Key) &&
                !incident.RaiseUser.Key.Equals(previousIncident.RaiseUser.Key))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "RaiseUser", Value = incident.RaiseUser.Key });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "RaiseUser", Value = previousIncident.RaiseUser.Key });
            }

            if (incident.ActualLocation != null && !string.IsNullOrEmpty(incident.ActualLocation.Key) &&
                !incident.ActualLocation.Key.Equals(previousIncident.ActualLocation.Key))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_Office1", Value = incident.ActualLocation.Key });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "_Office1", Value = previousIncident.ActualLocation.Key });
            }

            if (!string.IsNullOrEmpty(incident.Title) && !incident.Title.Equals(previousIncident.Title))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "Title", Value = incident.Title });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "Title", Value = previousIncident.Title });
            }

            if (!string.IsNullOrEmpty(incident.Description) && !incident.Description.Equals(previousIncident.Description))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "Description", Value = incident.Description });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "Description", Value = previousIncident.Description });
            }

            if (incident.Category != null && !string.IsNullOrEmpty(incident.Category.Key) &&
                !incident.Category.Key.Equals(previousIncident.Category.Key))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "Category", Value = incident.Category.Key });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "Category", Value = previousIncident.Category.Key });
            }

            if (incident.Urgency != null && !string.IsNullOrEmpty(incident.Urgency.Key) &&
                !incident.Urgency.Key.Equals(previousIncident.Urgency.Key))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_IncidentUrgency", Value = incident.Urgency.Key });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "_IncidentUrgency", Value = previousIncident.Urgency.Key });
            }

            if (incident.Source != null && !string.IsNullOrEmpty(incident.Source.Key) &&
                !incident.Source.Key.Equals(previousIncident.Source.Key))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_IncidentSource", Value = incident.Source.Key });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "_IncidentSource", Value = previousIncident.Source.Key });
            }

            if (incident.ResponseLevel != null && !string.IsNullOrEmpty(incident.ResponseLevel.Key) &&
                !incident.ResponseLevel.Key.Equals(previousIncident.ResponseLevel.Key))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "ResponseLevel", Value = incident.ResponseLevel.Key });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "ResponseLevel", Value = previousIncident.ResponseLevel.Key });
            }

            if (!string.IsNullOrEmpty(incident.FloorNumber) && !incident.FloorNumber.Equals(previousIncident.FloorNumber))
            {
                form.FormValues.Add(new FormPostPatch.FormItem() { Name = "_FloorNumber", Value = incident.FloorNumber });
                form.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "_FloorNumber", Value = previousIncident.FloorNumber });
            }

            return form;
        }
    }
}
