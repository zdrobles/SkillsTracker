using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills/")]
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<ol>" +
                    "<li>C#</li>" +
                    "<li>JavaScript</li>" +
                    "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        [HttpGet("form")]
        public IActionResult SkillsForm()
        {
            string html = "<form method='post' action='/skills/form/'><label>Date: <input type='date' name='date'></label><br>" +
                "<label>C#: <select name='csharp'></label>" +
                    "<option value ='learning basics' selected>Learning basics</option>" +
                    "<option value ='making apps'>Making apps</option>" +
                    "<option value ='master coder'>Master coder</option></select><br>" +
                "<label>JavaScript: <select name='js'></label>" +
                    "<option value ='learning basics' selected>Learning basics</option>" +
                    "<option value ='making apps'>Making apps</option>" +
                    "<option value ='master coder'>Master coder</option></select><br>" +
                "<label>Python: <select name='py'></label>" +
                    "<option value ='learning basics' selected>Learning basics</option>" +
                    "<option value ='making apps'>Making apps</option>" +
                    "<option value ='master coder'>Master coder</option></select><br>" +
                "<input type='submit'></form>";
            return Content(html, "text/html");
        }

        [HttpPost("form")]
        public IActionResult PostSkillsForm(string date, string csharp, string js, string py)
        {
            string html = $"<h1>{date}</h1>" +
                "<ol>" +
                    $"<li>C#: {csharp}</li>" +
                    $"<li>JavaScript: {js}</li>" +
                    $"<li>Python: {py}</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
    }
}
