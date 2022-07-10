using System;

namespace PlanBetter.Business.Exceptions
{
    public class NotAvailableException : ApplicationException
    {
        public NotAvailableException(string message) : base(message)
        {

        }
    }
}
