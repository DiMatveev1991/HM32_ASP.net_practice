﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HM32_ASP.net_practice.Models;

namespace HM32_ASP.net_practice.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Feedback feedback) => StatusCode(200, $"{feedback.From}, спасибо за отзыв!");

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}