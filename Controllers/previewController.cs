using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;

namespace _24hours.Controllers
{
    public class previewController : Controller
    {
        Iprject ob;
        public previewController(Iprject i)
        {
            ob = i;
        }
        //
        // GET: /preview/

        public ActionResult preview()
        {
            return View();
        }

    }
}
