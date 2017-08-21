using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrialStatusApplication.DatabaseQueries;
using TrialStatusApplication.Models;

namespace TrialStatusApplication.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            AdministratorViewModel viewModel = new AdministratorViewModel();
            TrialInfoQueries query = new TrialInfoQueries();
            viewModel.Trials = query.GetTrials();
            viewModel.User = new AdminUser { RealName = "Mr. Squiggles", Username="MSQUIGGLY"};
            viewModel.Judges = query.GetJudgesAndStatus();
            return View(viewModel);
        }
    }
}