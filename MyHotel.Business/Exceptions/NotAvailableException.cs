using System;

namespace MyHotel.Business.Exceptions
{
    public class NotAvailableException : ApplicationException
    {
        public NotAvailableException(string message) : base(message)
        {

        }
    }
}
