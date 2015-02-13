using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;

namespace _24hours.Controllers
{
    public class loginController : Controller
    {
        Iprject ob;
        Database1Entities2 db = new Database1Entities2();
        
       

        public loginController(Iprject i)
        {
            ob = i;
        }

        // GET: /login/
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult loginverify(user obj)
        {
            if (ob.Checkfun(obj))
            {
                Session["k1"] = ob.sessionid();
                return View("../Home/index");
            }
          

            return RedirectToAction("login");
        }

    }
}
