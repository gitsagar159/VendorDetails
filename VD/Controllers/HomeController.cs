using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VD.Models;

namespace VD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            VendorViewmodel model = new VendorViewmodel();
            return View(model.VendorList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Dashboard()
        {
            ViewModel model = new ViewModel();
            return View(model);
        }

        public ActionResult Search()
        {
            VendorViewmodel model = new VendorViewmodel();
            return View(model.VendorList);
        }

        [HttpPost]
        public ActionResult Search(string Name = "",long Number=0)
        {
            VendorViewmodel model = new VendorViewmodel();
            VendorViewmodel objData = new VendorViewmodel();
            if (Name != null)
            {
                objData.VendorList = model.VendorList.Where(x => x.FirstName.ToLower().Contains(Name.ToLower())).ToList();
            }
            return View(objData.VendorList);
        }
        
    }
}