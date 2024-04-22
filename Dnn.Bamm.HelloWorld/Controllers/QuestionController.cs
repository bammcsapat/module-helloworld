/*
' Copyright (c) 2024 BAMM
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using Bamm.Dnn.Dnn.Bamm.HelloWorld.Components;
using Bamm.Dnn.Dnn.Bamm.HelloWorld.Models;
using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Bamm.Dnn.Dnn.Bamm.HelloWorld.Controllers
{
    [DnnHandleError]
    public class QuestionController : DnnController
    {

        public ActionResult Delete(int QuestionId)
        {
            QuestionManager.Instance.DeleteQuestion(QuestionId, ModuleContext.ModuleId);
            return RedirectToDefaultRoute();
        }

        public ActionResult Edit(int QuestionId = -1)
        {
            DotNetNuke.Framework.JavaScriptLibraries.JavaScript.RequestRegistration(CommonJs.DnnPlugins);

            var userlist = UserController.GetUsers(PortalSettings.PortalId);
            var users = from user in userlist.Cast<UserInfo>().ToList()
                        select new SelectListItem { Text = user.DisplayName, Value = user.UserID.ToString() };

            ViewBag.Users = users;

            var Question = (QuestionId == -1)
                 ? new Questions { ModuleId = ModuleContext.ModuleId }
                 : QuestionManager.Instance.GetQuestion(QuestionId, ModuleContext.ModuleId);

            return View(Question);
        }

        [HttpPost]
        [DotNetNuke.Web.Mvc.Framework.ActionFilters.ValidateAntiForgeryToken]

        public ActionResult Index()
        {
            var Questions = QuestionManager.Instance.GetQuestions(ModuleContext.ModuleId);
            return View(Questions);
        }
    }
}
