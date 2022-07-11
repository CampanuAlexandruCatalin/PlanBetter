using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using PlanBetter.Business.Models;

namespace PlanBetter.Api.Validators
{
    public class ExamModelValidator: AbstractValidator<ExamModel>
    {
        public  ExamModelValidator()
        {
            RuleFor(p => p.Date.Date)
                .NotEmpty()
                .GreaterThanOrEqualTo(DateTime.Now.AddDays(5).Date)
                .WithMessage("You can add an exam  at least 5 days in advance  ");
            RuleFor(p => p.TimeStart)
                .NotEmpty()
                .WithMessage("Every exam should have a time when it starts");
            RuleFor(p => p.TimeEnd)
                .NotEmpty()
                .WithMessage("Every exam should have a time when it ends");
        }
    }

}
