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
        private readonly UserRepository userRepository;

        public HomeController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {

            ViewBag.users = userRepository.AllUsers();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
