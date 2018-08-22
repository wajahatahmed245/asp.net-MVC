using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace boilercode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string test(string id,string name )
        {
            return "id = " +id + " name = " + name;
        }

        public ActionResult test2(string id, string name)
        {
            //List<string> list1 = new List<string>;

            ViewBag.countries=new List<string>() {
                "pakistan",
                "india",
                "china",
                "afghanistan"
            };

            return View();
        }

        public ActionResult About( )
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact( )
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}