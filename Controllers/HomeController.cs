using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("result")]
        public IActionResult Result(Survey surveyData)
        {
            return View(surveyData);
        }

        [HttpPost("survey")]
        public IActionResult SurveySubmit(Survey surveyData)
        {
            return RedirectToAction("Result", surveyData);
        }
    }
}