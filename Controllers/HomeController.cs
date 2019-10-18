using Microsoft.AspNetCore.Mvc;

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
        public ViewResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = ((Name != null) ? Name : "");
            ViewBag.Location = ((Location != null) ? Location : "");
            ViewBag.Language = ((Language != null) ? Language : "");
            ViewBag.Comment = ((Comment != null) ? Comment : "");
            return View();
        }

        [HttpPost("survey")]
        public IActionResult SurveySubmit(string Name, string Location, string Language, string Comment)
        {
            return RedirectToAction("Result", new {Name = Name , Location = Location, Language = Language, Comment = Comment});
        }
    }
}