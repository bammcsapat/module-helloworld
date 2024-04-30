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

using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;
using System;
using System.Web.Caching;
using DotNetNuke.UI.Modules;
using Bamm.Dnn.Dnn.Bamm.HelloWorld.Models;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System.Collections.Generic;

namespace Bamm.Dnn.Dnn.Bamm.HelloWorld.Models
{
    [TableName("HelloWorld_Question")]
    [PrimaryKey("QuestionId", AutoIncrement = true)]
    [Cacheable("Questions", CacheItemPriority.Default, 20)]
    [Scope("ModuleId")]
    public class Questions
    {
        public int QuestionId { get; set; }

        public string Question { get; set; }

        //public string AnswerA { get; set; }

        //public string AnswerB { get; set; }

        //public string AnswerC { get; set; }

        //public int ModuleId { get; set; } = 410;


    }
}
