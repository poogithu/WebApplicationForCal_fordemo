using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForCal.Models;

namespace WebApplicationForCal.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new Calc());
        }
        [HttpPost]
        public ActionResult Index(Calc c,string calculate)
        {
            if (calculate == "add") 
            {
                c.tot = c.no1 + c.no2;

            }
            else if (calculate == "min") 
            {
                c.tot = c.no1 - c.no2;


            }
            else if (calculate == "sub") 
            {
                c.tot = c.no1 * c.no2;


            }
            else
            {
                c.tot = c.no1 - c.no2;
            }
            return View(c);
        }
    }
}