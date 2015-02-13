using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;

namespace _24hours.Controllers
{
    public class aboutController : Controller
    {
        Iprject ob;

        public aboutController(Iprject i)
        {
            ob = i;

        }
        // GET: /about/

        public ActionResult about()
        {
            return View();
        }

    }
}
