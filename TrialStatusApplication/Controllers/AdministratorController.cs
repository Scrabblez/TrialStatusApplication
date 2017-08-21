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
        //[Authorize]
        //[ValidateAntiForgeryToken]
        public ActionResult Index()
        {
            AdministratorViewModel viewModel = new AdministratorViewModel();
            TrialInfoQueries query = new TrialInfoQueries();
            viewModel.Trials = query.GetTrials();
            viewModel.User = new AdminUser { RealName = "Mr. Squiggles", Username="MSQUIGGLY"};
            viewModel.Judges = query.GetJudgesAndStatus();
            return View(viewModel);
        }

        //[AcceptVerbs(HttpVerbs.Post), Authorize]
        //[ValidateAntiForgeryToken]
        public ActionResult Update(Trial trialUpdates, Judge judgesUpdates, Trial assignedTrial)
        {
            TrialInfoQueries query = new TrialInfoQueries();
            if (assignedTrial != null)
            {
                query.AssignTrials(assignedTrial);
            }

            if (trialUpdates != null)
            {
                query.UpdateTrials(trialUpdates); 
            }

            if (judgesUpdates != null)
            {
                query.UpdateJudges(judgesUpdates); 
            }

            AdministratorViewModel viewModel = new AdministratorViewModel();

            viewModel.Trials = query.GetTrials();
            viewModel.User = new AdminUser { RealName = "Mr. Squiggles", Username = "MSQUIGGLY" };
            viewModel.Judges = query.GetJudgesAndStatus();
            return View(viewModel);
        }
    }
}