using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;

namespace _24hours.Controllers
{
    public class HomeController : Controller
    {
        Iprject ob;
        public HomeController(Iprject i)
        {
            ob = i;

        }
        //
        // GET: /Home/

        public ActionResult index()
        {
            return View();
        }
        public ActionResult logout()
        {
            Session["k1"] = null;

            return View("index");
        }
        public ActionResult preview2()
        {
           return View("preview2");
        }

        public ActionResult preview3()
        {
            return View("preview3");
        }
        
    }
}
