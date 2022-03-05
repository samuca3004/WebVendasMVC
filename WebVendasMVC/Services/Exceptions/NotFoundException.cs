using System;

namespace WebVendasMVC.Services.Exceptions
{
   
        public class NotFoundException : ApplicationException
        {
            public NotFoundException(string message) : base(message)
            {
            }
        }
    }


