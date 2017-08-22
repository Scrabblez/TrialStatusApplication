using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrialStatusApplication.Models
{
    public class CustomUser : IUser<string>
    {
        public string Id { get; }

        public string UserName { get;  set; }
    }
}