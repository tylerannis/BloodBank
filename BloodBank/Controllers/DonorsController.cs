using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodBank.Controllers
{
    public class DonorsController : Controller
    {
        Models.BloodBankEntities db = new Models.BloodBankEntities();
        //
        // GET: /Donors/

        public ActionResult Index()
        {
            return View(db.Donors2);
        }
        public ActionResult Details(int id)
        {
            return View(db.Donors2.Find(id));
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.Donors2.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(int ID, Models.Donors2 donorEdit)
        {
            //tell the DB context that the contact form needs to be updated
            db.Entry(donorEdit).State = System.Data.EntityState.Modified;
            //save changes
            db.SaveChanges();
            //kick user back to list

            return RedirectToAction("Index", "Donors");
        }


        public ActionResult Delete(int id)
        {
                   return View(db.Donors2.Find(id));
        }

        public ActionResult DeleteConfirm(int ID)
        {
            //get the form to delet from the database
            Models.Donors2 formToDelete = db.Donors2.Find(ID);
            //remove from formtoDelete
            db.Donors2.Remove(formToDelete);

            db.SaveChanges();
        //kick them back to the list
            return RedirectToAction("Index", "Donors");
        }
    }
    
}
