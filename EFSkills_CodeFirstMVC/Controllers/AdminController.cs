using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSkills_CodeFirstMVC.Models.Classes;

namespace EFSkills_CodeFirstMVC.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Skills.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(Skill s)
        {
            c.Skills.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var skillToDel = c.Skills.Find(id);
            c.Skills.Remove(skillToDel);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var skillToUpd = c.Skills.Find(id);
            return View("UpdateSkill",skillToUpd);
        }       
        [HttpPost]
        public ActionResult UpdateSkill(Skill s)
        {
            var skillToUpd = c.Skills.Find(s.Id);
            skillToUpd.Desc = s.Desc;
            skillToUpd.Value = s.Value;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}