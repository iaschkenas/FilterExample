using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace FilterExample.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Subscriber_Read([DataSourceRequest] DataSourceRequest request)
        {
            DataSourceResult result = null;

            try
            {
                var l = new List<Subscriber>();
                //var s = new Subscriber();
                //s.Company = "ABC";
                //s.Country = "USA";
                //l.Add(s);

                //s = new Subscriber();
                //s.Company = "XYZ";
                //s.Country = "USA";
                //l.Add(s);



                result = l.ToDataSourceResult(request, ModelState);
            }
            catch (Exception ex)
            {
                result = new DataSourceResult { Errors = ex.Message };
            }

            return Json(result);
        }
    }
}
