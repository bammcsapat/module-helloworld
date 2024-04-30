using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Bamm.Dnn.Dnn.Bamm.HelloWorld.Models
{
    [TableName("HelloWorld_Answers")]
    [PrimaryKey("AnswerId", AutoIncrement = true)]
    [Cacheable("Answers", CacheItemPriority.Default, 20)]
    [Scope("ModuleId")]
    public class Answers
    {
        public int AnswerId { get; set; }

        public int QuestionId { get; set; }

        public string Answer { get; set; }

        public int NextQuestionId { get; set; }

    }
}