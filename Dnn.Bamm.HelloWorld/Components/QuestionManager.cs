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

using Bamm.Dnn.Dnn.Bamm.HelloWorld.Models;
using DotNetNuke.Data;
using DotNetNuke.Framework;
using System.Collections.Generic;

namespace Bamm.Dnn.Dnn.Bamm.HelloWorld.Components
{
    internal interface IQuestionManager
    {
        void CreateQuestion(Questions t);
        void DeleteQuestion(int QuestionId, int moduleId);
        void DeleteQuestion(Questions t);
        IEnumerable<Questions> GetQuestions(int moduleId);
        Questions GetQuestion(int QuestionId, int moduleId);
        void UpdateQuestion(Questions t);
    }

    internal class QuestionManager : ServiceLocator<IQuestionManager, QuestionManager>, IQuestionManager
    {
        public void CreateQuestion(Questions t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Questions>();
                rep.Insert(t);
            }
        }

        public void DeleteQuestion(int QuestionId, int moduleId)
        {
            var t = GetQuestion(QuestionId, moduleId);
            DeleteQuestion(t);
        }

        public void DeleteQuestion(Questions t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Questions>();
                rep.Delete(t);
            }
        }

        public IEnumerable<Questions> GetQuestions(int moduleId)
        {
            IEnumerable<Questions> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Questions>();
                t = rep.Get(moduleId);
            }
            return t;
        }

        public Questions GetQuestion(int QuestionId, int moduleId)
        {
            Questions t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Questions>();
                t = rep.GetById(QuestionId, moduleId);
            }
            return t;
        }

        public void UpdateQuestion(Questions t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Questions>();
                rep.Update(t);
            }
        }

        protected override System.Func<IQuestionManager> GetFactory()
        {
            return () => new QuestionManager();
        }
    }
}
