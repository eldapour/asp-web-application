using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.database;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class testController:Controller
    {
       public ActionResult index()
        {
            dbContainer db = new dbContainer();
            

            ViewBag.users = db.users.Select(user => user);
            return View("~/Views/index.cshtml");
        }

        public void create(User user)
        {
            //
        }
    }
}
