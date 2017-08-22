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
            viewModel.User = new AdminUser { RealName = "Mr. Squiggles", Username = "MSQUIGGLY" };


            Statuses statusList = new Statuses();
            viewModel.Statuses = statusList;

            //REMOVE WHEN READY
            Judge bortner = new Judge();
            bortner.JudgeName = "Bortner";
            bortner.Status = "Bortner";
            bortner.CurrentTrial = new Trial { ID = Guid.NewGuid(), DEFENSE_ATTORNEY ="Ronald McDonald", CASE_NUMBER = "1234", PROSECUTOR ="Col. Sanders", DEFENDANT_NAME ="Chicken McNugget"};
            Judge musticook = new Judge();
            musticook.JudgeName = "Musti-Cook";
            musticook.Status = "Musti-Cook";
            musticook.CurrentTrial = new Trial { ID = Guid.NewGuid(), DEFENSE_ATTORNEY = "Ronald McDonald", CASE_NUMBER = "1234", PROSECUTOR = "Col. Sanders", DEFENDANT_NAME = "Chicken McNugget" };
            Judge ness = new Judge();
            ness.JudgeName = "Ness";
            ness.Status = "Ness";
            ness.CurrentTrial = new Trial { ID = Guid.NewGuid(), DEFENSE_ATTORNEY = "Ronald McDonald", CASE_NUMBER = "1234", PROSECUTOR = "Col. Sanders", DEFENDANT_NAME = "Chicken McNugget" };
            Judge snyder = new Judge();
            snyder.JudgeName = "Snyder";
            snyder.Status = "Snyder";
            snyder.CurrentTrial = new Trial { ID = Guid.NewGuid(), DEFENSE_ATTORNEY = "Ronald McDonald", CASE_NUMBER = "1234", PROSECUTOR = "Col. Sanders", DEFENDANT_NAME = "Chicken McNugget" };
            Judge trebilcock = new Judge();
            trebilcock.JudgeName = "Trebilcock";
            trebilcock.Status = "Trebilcock";
            trebilcock.CurrentTrial = new Trial { ID = Guid.NewGuid(), DEFENSE_ATTORNEY = "Ronald McDonald", CASE_NUMBER = "1234", PROSECUTOR = "Col. Sanders", DEFENDANT_NAME = "Chicken McNugget" };
            List<Judge> listJudge = new List<Judge> { bortner, musticook, ness, snyder, trebilcock };
            viewModel.Judges = listJudge;


            //viewModel.Judges = query.GetJudgesAndStatus(); //UNCOMMENT WHEN READY
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