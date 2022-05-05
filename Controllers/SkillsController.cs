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
            string html = "<form method='post' action='/skills/submission/'><label>Date: <input type='date' name='date'></label><br>" +
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

        [HttpPost("submission")]
        public IActionResult PostSkillsForm(string date, string csharp, string js, string py)
        {
         //ordered list
            //string html = $"<h1>{date}</h1>" +
            //    "<ol>" +
            //        $"<li>C#: {csharp}</li>" +
            //        $"<li>JavaScript: {js}</li>" +
            //        $"<li>Python: {py}</li>" +
            //    "</ol>";

        //2 by 3 table
            //string html = $"<h1>{date}</h1>" +
            //    "<table>" +
            //        "<thead><tr>" +
            //            "<th>C#</th>" +
            //            "<th>JavaScript</th>" +
            //            "<th>Python</th>" +
            //        "</tr></thead>" +
            //        "<tbody><tr>" +
            //            $"<td>{csharp}</td>" +
            //            $"<td>{js}</td>" +
            //            $"<td>{py}</td>" +
            //        "</tr></tbody>" +
            //    "</table>";

        //3 by 2 table
            string html = $"<h1>{date}</h1>" +
                "<table>" +
                    "<tr>" +
                        "<th>C#</th>" +
                        $"<td>{csharp}</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<th>JavaScript</th>" +
                        $"<td>{js}</td>" +
                    "</tr>" +

                    "<tr>" +
                        "<th>Python</th>" +
                        $"<td>{py}</td>" +
                    "</tr>" +                        
                "</table>";
            return Content(html, "text/html");
        }
    }
}
