using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fluid_layout.Models;


namespace fluid_layout.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            BannerAL access = new BannerAL();
            BannerLine banner = access.getBanner();

            ViewBag.banner = banner;

            return View();
        }
    }
}