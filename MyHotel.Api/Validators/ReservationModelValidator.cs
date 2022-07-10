using FluentValidation;
using MyHotel.Business.Models;
using System;

namespace MyHotel.Api.Validators
{
    public class ReservationModelValidator : AbstractValidator<ReservationModel>
    {
        public ReservationModelValidator()
        {
            RuleFor(p => p.CheckIn.Date)
                .NotEmpty()
                .GreaterThanOrEqualTo(DateTime.Now.AddDays(1).Date)
                .WithMessage("You can make a reservation starting from tomorrow");

            RuleFor(p => p.Guest)
                .NotNull()
                .WithMessage("Every reservation should have a guest");

            //RuleFor(p => new { p.CheckIn, p.CheckOut })
            //    .NotEmpty()
            //    .Must(a  => DateTime.Compare( a.CheckIn, a.CheckOut) < 0)            
            //    .WithMessage("You can make a reservation starting from tomorrow");


            RuleFor(p => p.CheckOut.Date)
                .NotEmpty()
                .GreaterThan(p => p.CheckIn.Date)
                .WithMessage("You can make a reservation starting from tomorrow");

        }
    }
}
