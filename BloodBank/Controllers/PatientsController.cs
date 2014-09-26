using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodBank.Controllers
{
    public class PatientsController : Controller
    {
        Models.BloodBankEntities db = new Models.BloodBankEntities();
        //
        // GET: /Patients/

        public ActionResult Index()
        {
            return View(db.Patients2);
        }
        public ActionResult Details(int ID)
        {
            return View(db.Patients2.Find(ID));
        }


        [HttpGet]
        public ActionResult Edit(int ID)
        {
            return View(db.Patients2.Find(ID));
        }

        [HttpPost]
        public ActionResult Edit(int ID, Models.Patients2 patientForm)
        {
            //tell the DB context that the contact form needs to be updated
            db.Entry(patientForm).State = System.Data.EntityState.Modified;
            //save changes
            db.SaveChanges();
            //kick user back to list

            return RedirectToAction("Index", "Patients");
        }

        public ActionResult Delete(int ID)
        {
            return View(db.Patients2.Find(ID));
        }

        public ActionResult DeleteConfirm(int ID)
        {
            //get the form to delet from the database
            Models.Patients2 formToDelete = db.Patients2.Find(ID);
            //remove from formtoDelete
            db.Patients2.Remove(formToDelete);

            db.SaveChanges();
            //kick them back to the list
            return RedirectToAction("Index", "Patients");
        }

    }
}
