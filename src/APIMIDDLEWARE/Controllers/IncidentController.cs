using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMIDDLEWARE._Functions;
using APIMIDDLEWARE._Functions.Models;
using APIMIDDLEWARE.SharedModels;
using APIMIDDLEWARE.Triggers.Rest;
using APIMIDDLEWARE.Triggers.Rest.ModelTemplates;
using Microsoft.AspNetCore.Mvc;

namespace APIMIDDLEWARE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentController : ControllerBase
    {
        // GET: api/Sample
        [HttpGet]
        public string Get()
        {
            var requestInfo = new WebRequestInfo(WebRequestInfo.WebServiceType.SOAP,
                "https://localhost:44384/service.asmx");
            var requestData = CustomWebRequest.Send(requestInfo);
            return requestData;
        }

        // GET: api/Sample/5
        [HttpGet("{id}", Name = "Get")]
        public object Get(string id)
        {
            //return id;
            var a = new IncidentHandler();
            var b = a.GetIncidentObject(id);

            if (b != null)
                return b;
            return NotFound();

            //var a = new IncidentHandler();
            //var c = new IncidentHandler.CustomField();
            //c.Summary = "TESTING API 15";
            //c.TicketNumber = "WS00-20190710";
            //var b = a.GetIncidentListByCustomFields(c);
            //if (b == null)
            //    return NotFound();
            //return b;

            //var a = new IncidentResponseLevelHandler();
            //var b = a.GetResponseLevel(id);
            //if (b == null)
            //    return NotFound();
            //return b;


            //WS00-20190710-IM-0011
            //var a = new Ivanti();
            //var result = a.GetIncident(id);
            //if (result == null) return NotFound();
            //return result;

            //var a = new Ivanti();
            //var result = a.GetIncidentByGuid("f759c3f3-2f4c-4938-8e97-2477182700ef");
            //if (result == null) return NotFound();
            //return result;

            //var a = new Ivanti();
            //var b = new FormPostPatch.InsertionItem();
            //b.FormValues.Add(new FormPostPatch.FormItem() { Name = "Title", Value = "Title - " + id });
            //b.FormValues.Add(new FormPostPatch.FormItem() { Name = "Description", Value = "Description - " + id });
            //return a.AddIncident(b);

            //var a = new Ivanti();
            //var b = new FormPostPatch.UpdationItem();
            //b.FormValues.Add(new FormPostPatch.FormItem() { Name = "Title", Value = "TITLE - 123" });
            //b.FormValues.Add(new FormPostPatch.FormItem() { Name = "Description", Value = "DESCRIPTION - 123" });
            //b.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "Title", Value = "Title - f759c3f3-2f4c-4938-8e97-2477182700ef" });
            //b.OriginalValues.Add(new FormPostPatch.FormItem() { Name = "Description", Value = "Description - f759c3f3-2f4c-4938-8e97-2477182700ef" });
            //b.LockVersion = 1;
            //var result = a.UpdateIncident("b76c1163-0505-4c07-bd2c-23bdc5704582", b);
            //if (result == null)
            //    return NotFound();
            //return result;
        }

        // POST: api/Sample
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return value;
        }

        // PUT: api/Sample/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
