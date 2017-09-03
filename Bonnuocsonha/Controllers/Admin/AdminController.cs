using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bonnuocsonha.Models;
namespace Bonnuocsonha.Controllers.Admin
{
    public class AdminController : Controller
    {
        BonnuocsonhaContext db = new BonnuocsonhaContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult partialBanner()
        {
            ViewBag.donhang = db.tblOrders.Where(p => p.Status == false && p.Active==true).ToList().Count;
            return PartialView();
        }
    }
}