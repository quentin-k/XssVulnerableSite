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

        [HttpGet]
        public IActionResult HtmlInput()
        {
            HtmlInput model = new HtmlInput
            {
                Name = null
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult HtmlInput(HtmlInput model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult JsInput()
        {
            JsInput model = new JsInput
            {
                FavoriteColor = null
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult JsInput(JsInput model)
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult CommentInput()
        {
            CommentInput model = new CommentInput
            {
                FavoriteFood = null
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult CommentInput(CommentInput model)
        {
            return View(model);
        }
    }
}