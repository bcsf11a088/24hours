using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;

namespace _24hours.Controllers
{
    public class productsController : Controller
    {
        Iprject ob;
        public productsController(Iprject i)
        {
            ob = i;
        }
        //
        // GET: /products/

        public ActionResult products()
        {
            return View();
        }

    }
}
