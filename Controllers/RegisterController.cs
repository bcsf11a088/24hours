using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;

namespace _24hours.Controllers
{
    public class RegisterController : Controller
    {
        Iprject ob;
        public RegisterController(Iprject i)
        {
            ob = i;
        }
        //
        // GET: /Register/
        [HttpPost ]
        public ActionResult register(user obj)

        {
            ob.Register(obj);
            
           
            return RedirectToAction("../Home/index");
        }

        public JsonResult checkemail(string email)
        { 
            Database1Entities2 db = new Database1Entities2();
            var q = from y in db.users
                    select y;
            string status="";
            foreach(var s in q)
            {
                if(s.Email==email)
                {
                    status="Email already exists!!";
                    break;
                }else
                {
                    status="Email is fine!!";
                }
            }
            return this.Json(status, JsonRequestBehavior.AllowGet);
        }

    }
}
