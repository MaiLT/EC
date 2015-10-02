using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectEC.Areas.Client.Controllers
{
    public class SharedController : Controller
    {
        // GET: Client/Shared
        public ActionResult Layout()
        {
            return View();
        }
    }
}