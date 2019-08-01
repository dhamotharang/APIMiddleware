using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.SharedModels;
using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static APIMIDDLEWARE.SharedModels.Incident;

namespace APIMIDDLEWARE.Triggers.Rest
{
    public class UserDetailsHandler : RestClient
    {
        public UserDetailsHandler() { RequestClassName = "System.User"; }
        public QueryGet.UserQuery GetUserDetailByEmailAddress(string userEmailAddress)
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.REST,
                $"{ClientUrl}query?class_name={RequestClassName}&query=_AllUser&attributes=Title%2CUserType.Title%2CEMailAddress%2C_Office1._Title%2C_Section21._Title%2C_State1._Title%2C_Department.Title&cns=EMailAddress-e-0&c0={userEmailAddress}&v=*",
                RequestType.GET, ContentType.TEXT, string.Empty, Credential);
            var responseData = CustomWebRequest.Send<QueryGet.UserQuery>(requestInfo);
            return CustomWebRequest.Send<QueryGet.UserQuery>(requestInfo);
        }

        public static IUser ConvertFormToObject(QueryGet.UserQuery UserForm)
        {
            IUser RaiseUser = new IUser();
            //var userInfo = UserForm.FormItems.Where(x => x.Label.Equals(IUser.FormItemGroupLabel)).FirstOrDefault();
            if (UserForm.TotalCount > 0)
            {
                var raiseUser = UserForm.DataRows[0].Values;
                if (raiseUser != null)
                {
                    RaiseUser.Key = UserForm.DataRows[0].Key.ToString();
                    RaiseUser.Name = raiseUser.Title;
                }

                if (raiseUser.EMailAddress != string.Empty)
                    RaiseUser.Email = raiseUser.EMailAddress;

                if (raiseUser._Office1 != null)
                {
                    OfficeHandler officeH = new OfficeHandler();
                    var query = officeH.GetOfficeListByName(raiseUser._Office1._Title);
                    IOffice office = new IOffice();
                    if (query.DataRows.Length > 0)
                    {
                        office.Key = query.DataRows[0].Key;
                        office.Name = query.DataRows[0].Values._Title;
                    }
                    RaiseUser.Office = office;
                }

                if (raiseUser._Section21 != null)
                {
                    SectionHandler sectionH = new SectionHandler();
                    var query = sectionH.GetSectionListByName(raiseUser._Section21._Title);
                    ISection section = new ISection();
                    if(query.DataRows.Length > 0)
                    {
                        section.Key = query.DataRows[0].Key;
                        section.Name = query.DataRows[0].Values._Title;
                    }
                    RaiseUser.Section = section;
                }

                if (raiseUser._State1 != null)
                {
                    StateHandler stateH = new StateHandler();
                    var query = stateH.GetStateListByName(raiseUser._State1._Title);
                    IState state = new IState();
                    if(query.DataRows.Length > 0)
                    {
                        state.Key = query.DataRows[0].Key;
                        state.Name = query.DataRows[0].Values._Title;
                    }
                    RaiseUser.State = state;
                }

                if (raiseUser._Department != null)
                {
                    CustomerHandler customerH = new CustomerHandler();
                    var query = customerH.GetStateListByName(raiseUser._Department.Title);
                    IGroup group = new IGroup();
                    if(query.DataRows.Length > 0)
                    {
                        group.Key = query.DataRows[0].Key;
                        group.Name = query.DataRows[0].Values.Title;
                    }
                    RaiseUser.Group = group;
                }
            }
            return RaiseUser;
        }
    }
}
