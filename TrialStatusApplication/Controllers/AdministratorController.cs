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
            viewModel.User = new AdminUser { RealName = "Mr. Squiggles", Username = "MSQUIGGLY" };



            Statuses statusList = new Statuses();
            viewModel.Statuses = statusList;

            //REMOVE WHEN READY
            Judge bortner = new Judge();
            bortner.JudgeName = "Bortner";
            Judge musticook = new Judge();
            musticook.JudgeName = "Musti-Cook";
            Judge ness = new Judge();
            ness.JudgeName = "Ness";
            Judge snyder = new Judge();
            snyder.JudgeName = "Snyder";
            Judge trebilcock = new Judge();
            trebilcock.JudgeName = "Trebilcock";
            List<Judge> listJudge = new List<Judge> { bortner, musticook, ness, snyder, trebilcock };
            viewModel.Judges = listJudge;
            //


            //viewModel.Judges = query.GetJudgesAndStatus(); //UNCOMMENT WHEN READY
            return View(viewModel);
        }
    }
}