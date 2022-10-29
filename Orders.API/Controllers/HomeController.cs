using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Orders.API.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return Ok("wELCOME TO API project");
        }

       
    }
}