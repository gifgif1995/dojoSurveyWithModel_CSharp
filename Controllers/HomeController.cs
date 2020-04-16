using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dojoSurveyWithModels.Models;

namespace dojoSurveyWithModels.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost("results")]
        public IActionResult Submission(Survey mySurvey)
        {
            {
                return View("results", mySurvey);
            }
        }
    }
}