using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuestionAppService.DataObjects
{
    [Table("questions")]
    public class ExamQuestion : EntityData
    {
        public string Id { get; set; }
        public string Question { get; set; }
        public bool Answer { get; set; }
        public string Explanation { get; set; }

    }
}