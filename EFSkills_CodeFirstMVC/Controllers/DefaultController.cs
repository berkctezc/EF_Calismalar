using System.Linq;
using System.Web.Mvc;
using EFSkills_CodeFirstMVC.Models.Classes;

namespace EFSkills_CodeFirstMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var values = c.Skills.ToList();
            return View(values);
        }
    }
}