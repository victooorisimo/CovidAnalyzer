﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CovidAnalyzer.Controllers {
    public class HomeController : Controller {
        public ActionResult InitialPage() {
            return View();
        }

        public ActionResult Panel(){
            return View("Panel");
        }

        public ActionResult PatientsList(){
            return View();
        }
    }
}