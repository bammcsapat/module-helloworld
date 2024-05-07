using Bamm.Dnn.Dnn.Bamm.HelloWorld.Components;
using Bamm.Dnn.Dnn.Bamm.HelloWorld.Models;
using DotNetNuke.Data;
using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Bamm.Dnn.Dnn.Bamm.HelloWorld.Controllers
{
    public class QuestionController : Controller
    {
        public Questions GetQuestionById(int id)
        {
            using (var ctx = DataContext.Instance())
            {
                var q = ctx.GetRepository<Questions>();
                return q.GetById(id);
            }
        }

        public Answers[] GetAnswerByQuestion(int questionId)
        {
            using (var ctx = DataContext.Instance())
            {
                return ctx.GetRepository<Answers>().Find("WHERE QuestionId = @0", questionId).ToArray();
            }
        }

        private int nextId = 0; // Variable declared at the controller level

        public ActionResult Index()
        {
            // Pass the variable to the view
            ViewBag.MyVariable = nextId;
            return View();
        }

        [HttpPost]
        public ActionResult IncrementVariable()
        {
            // Increment the variable
            nextId++;

            // Optionally, you can redirect to another action or return a view
            return RedirectToAction("Index");
        }
    }
}
