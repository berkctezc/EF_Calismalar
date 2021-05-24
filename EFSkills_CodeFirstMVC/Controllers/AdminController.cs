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
        // GET: Admin
        public ActionResult Index()
        {
            Context c = new Context();
            var values = c.Skills.ToList();
            return View(values);
        }
    }
}