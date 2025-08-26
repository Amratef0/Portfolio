using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Interfaces;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContactRepository _contactRepository;

        public HomeController(ILogger<HomeController> logger, IContactRepository contactRepository)
        {
            _logger = logger;
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ContactMe()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveContactMe(ContactUs contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contactRepository.Add(contact);
                    TempData["Success"] = "Your message has been sent successfully!";
                    return RedirectToAction("Index", "Home");
                }

                return View("ContactMe", contact); 
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong. Please try again later.");
                return View("ContactMe", contact);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
