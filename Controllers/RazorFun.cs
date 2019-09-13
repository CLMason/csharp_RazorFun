using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace RazorFun.Controllers
{
    public class RazorFunController : Controller
    {
        [HttpGet]
        [Route ("")]
        public IActionResult Index ()
        {
            return View();
        }
    }
        
}