using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24hours.Models;
using System.IO;

namespace _24hours.Controllers
{
    public class AdminController : Controller
    {
        Database1Entities2 db = new Database1Entities2();
        //
        // GET: /Agmin/

        public ActionResult Index()
        {

            return View(db.Products.ToList());

        }



        public ActionResult Create()
        {

            return PartialView("Pview");

        }



        [HttpPost]

        public ActionResult Create(HttpPostedFileBase imageFile, Product model, string cmd)
        {

            try
            {

                if (imageFile != null && imageFile.ContentLength > 0)
                {

                    var fileName = Path.GetFileName(imageFile.FileName);

                    if (cmd == "Create")
                    {

                        model.Image = fileName;

                        db.Products.Add(model);

                        db.SaveChanges();

                    }

                    else
                    {

                        var actor = db.Products.Where(m => m.Pid == model.Pid).FirstOrDefault();

                        if (actor != null)
                        {

                            actor.Image = fileName;

                            db.SaveChanges();

                        }

                    }



                    var path = Path.Combine(Server.MapPath("~/images/"), model.Pid.ToString());

                    if (!Directory.Exists(path))

                        Directory.CreateDirectory(path);

                    imageFile.SaveAs(path + "/" + fileName);

                }

            }

            catch { }



            return RedirectToAction("Index");

        }



        public ActionResult Edit(int id)
        {

            var actor = db.Products.Where(m => m.Pid == id).FirstOrDefault();

            ViewBag.IsUpdate = true;

            return PartialView("Pview");

        }



        public ActionResult Delete(int id)
        {

            var actor = db.Products.FirstOrDefault(m => m.Pid == id);

            if (actor != null)
            {

                db.Products.Remove(actor);

                db.SaveChanges();

            }

            return RedirectToAction("Index");

        }



        public ActionResult GetActorList()
        {

            return PartialView("Add", db.Products.ToList());

        }

    }
}
