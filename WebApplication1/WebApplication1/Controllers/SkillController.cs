using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;

namespace WebApplication1.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        Context db= new Context();
        public ActionResult Index()
        {
            List<Skill> SkillsList = db.Skills.ToList();
            return View(SkillsList);
        }
    }
}