using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class testController:Controller
    {
       public ActionResult index()
        {
            //return "Welcome to Ya Abdallah";
            return View("~/Views/index.cshtml");
        }

        public void create(string userName, string password)
        {
            //
        }
    }
}
