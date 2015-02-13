using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;

namespace _24hours.Controllers
{
    public class contactController : Controller
    {
        Iprject ob;

        public contactController(Iprject i)
        {
            ob = i;
        }
        // GET: /contact/
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult Addcontact(contact obj)
        {
            ob.contact(obj);

            return RedirectToAction("../Home/index");
        }

    }
}
