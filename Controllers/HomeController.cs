
using System;

using System.Web.Mvc;

using Assignment1.Managers;
using Assignment1.Dtos;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public HomeManager Manager { get => new HomeManager(); }
        [HttpGet]
       
        public ActionResult ViewNotes(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "title" : "";
            ViewBag.DateSortParm = sortOrder == "DateC" ? "DateC_desc" : "DateC";
         //  ViewBag.DateSortParm2 = sortOrder == "DateM" ? "DateM_desc" : "DateC";

            return View(Manager.GetByOrder(sortOrder));
        }
        public ActionResult AddNote()
        {
            ViewBag.Title = "Add a note";



            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNote(HomeDto model)
        {
            if (ModelState.IsValid)
            {
                Manager.AddNote(model);
                return RedirectToAction("ViewNotes");
            }

            return View();
        }
        //get
        public ActionResult Delete(int id)
        {
            return View(Manager.GetEditDetails(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(HomeDto model)
        {
            Manager.RemoveNote(model.Id);
            return RedirectToAction("ViewNotes");
        }
        //Get
        public ActionResult ModifyNote(int id)
        {
            
            return View(Manager.GetEditDetails(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ModifyNote(HomeDto model)
        {
            if (ModelState.IsValid)
            {
                Manager.EditNote(model);
                return RedirectToAction("ViewNotes");
            }
            return View();
        }

        public ActionResult DisplayNote(int id)
       {
          

            return View(Manager.GetDetails(id));
        }
    }
}
