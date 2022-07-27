using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Models
{
    public sealed class AddAnswerModel
    {
        public int TeacherId { get; set; }
        public string AnswerText { get; set; }
    }
}
