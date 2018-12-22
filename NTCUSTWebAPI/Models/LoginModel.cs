using Swashbuckle.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTCUSTWebAPI.Models
{
    public class LoginModel
    {
        public string Account { get; set; }
        public string Password { get; set; }
    }


    public class LoginModelExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new LoginModel
            {
                Account = "Tom",
                Password = "123456"
            };
        }
    }
}
