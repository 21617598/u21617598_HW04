using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using homework4.Models;

namespace homework4.Controllers
{
    public class CampaignController : Controller
    {
        // GET: Campaign
        public ActionResult Project()
        {
            return View();
        }


        // [HttpGet]
        public ActionResult Sealife()
        {
            return View();
        }

        public static List<Animal> animals = new List<Animal>();
        [HttpPost]
        public ActionResult Sealife(string sealife, int num)
        {
            if (num == 1)
            {
                Whale mywhale = new Whale()
                {
                    Type = sealife,
                };
                animals.Add(mywhale);
            }
            else if (num == 2)
            {
                Seal myseal = new Seal()
                {
                    Type = sealife,
                };
                animals.Add(myseal);
            }

            else if (num == 3)
            {
                Turtle myseaturtle = new Turtle()
                {
                    Type = sealife,

                };
                animals.Add(myseaturtle);
            }

            else if (num == 4)
            {
                Shark myshark = new Shark()
                {
                    Type = sealife,

                };
                animals.Add(myshark);
            }

            return RedirectToAction("home");
        }
    }
}