using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace TrialStatusApplication.Models
{
    public class CustomSignInManager : SignInManager<CustomUser, string>
    {
        public CustomSignInManager(UserManager<CustomUser, string> userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager)
        {
        }
    }
}