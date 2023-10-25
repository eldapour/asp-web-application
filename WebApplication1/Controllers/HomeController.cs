using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            UserRepository userRepository = new UserRepository();
            ViewBag.users = userRepository.AllUsers();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
