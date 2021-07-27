using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.CustomFilters;
using WebApplication7.Http;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[HandleException]
        //public IActionResult Index()
        //{
        //    throw new Exception("This is a sample exception!!!");
        //    return View();
        //}
        //public interface IAsyncAuthorizationFilter : IFilterMetadata
        //{
        //    Task OnAuthorizationAsync(AuthorizationFilterContext context);
        //}
        [HttpsOnly]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }
        [ResultF]
        public ViewResult Message() => View();

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
