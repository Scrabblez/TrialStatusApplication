using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrialStatusApplication.DatabaseQueries;
using TrialStatusApplication.Models;

namespace TrialStatusApplication.Controllers
{
    public class TrialsController : Controller
    {
        public ActionResult Index()
        {
            TrialInfoQueries querier = new TrialInfoQueries();
            List<Trial> trials = querier.GetTrials();
            List<Judge> judges = querier.GetJudgesAndStatus();
            return View(new CurrentTrialsViewModel { UpcomingTrials= trials, Judges = judges});
        }
    }
}