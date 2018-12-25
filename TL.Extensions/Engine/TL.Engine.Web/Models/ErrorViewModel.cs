using Microsoft.AspNetCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TL.Engine.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int StatusCode { get; set; }

        public IExceptionHandlerFeature Exception { get; set; }

        public string ReturnUrl { get; set; }
    }
}
