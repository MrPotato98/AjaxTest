using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult UploadImage()
        {
            return View();
        }
        public String ProcessUpload(HttpPostedFileBase file)
        {
            file.SaveAs(Server.MapPath("~/Content/images/") + file.FileName);
            return "/Content/images/" + file.FileName;
        }
    }
}
