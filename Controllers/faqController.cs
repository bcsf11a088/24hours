using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;

namespace _24hours.Controllers
{
    public class faqController : Controller
    {
        Iprject ob;
        public faqController(Iprject i)
        {
            ob = i;
        }
        //
        // GET: /faq/

        public ActionResult faq()
        {
            return View();
        }

    }
}
