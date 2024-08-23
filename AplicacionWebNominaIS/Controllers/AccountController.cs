using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AplicacionWebNominaIS.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            ViewBag.Message = "Iniciar Sesión";
            return View();
        }


        public ActionResult Register()
        {
            ViewBag.Message = "Registro";
            return View();
        }
    }
}


