using RenatoSfera.DOM;
using RenatoSfera.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenatoSfera.Web.Controllers
{
    public class HomeController : Controller
    {
        ShowBLL objShowBll;

        public HomeController()
        {
            objShowBll = new ShowBLL();
        }

        public ActionResult Index()
        {
            List<Show> lista = objShowBll.FindAll();
            return View(lista);
        }
    }
}