using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMSTest.Models;
using Twilio.Mvc;
using Twilio;
using Twilio.Model;
using Twilio.TwiML.Mvc;
using Twilio.TwiML.Verbs;

namespace SMSTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var myExample = new SampleMessage();
            var error = myExample.SendSample();
            ViewBag.Response = "Your error is " + error;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}