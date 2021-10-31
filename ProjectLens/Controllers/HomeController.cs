using el_proyecte_grande_sprint_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace el_proyecte_grande_sprint_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IPictureStorage _pictureStorage;
        public HomeController(ILogger<HomeController> logger, IPictureStorage pictureStorage)
        {
            _logger = logger;
            _pictureStorage = pictureStorage;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PicturesPage()
        {
            var pictures = _pictureStorage.GetAllPictures();

            return View(pictures);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
