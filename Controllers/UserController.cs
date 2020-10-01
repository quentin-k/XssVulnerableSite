using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using XssVulnerableSite.Models;

namespace XssVulnerableSite.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HtmlInput()
        {
            return View();
        }

        public IActionResult JsInput()
        {
            return View();
        }
    }
}