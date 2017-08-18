using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrialStatusApplication.Models;

namespace TrialStatusApplication.DatabaseQueries
{
    public class TrialInfoQueries
    {

        public List<Trial> GetTrials()
        {
            TrialStatusEntities1 db = new TrialStatusEntities1();
            var trials = from trial in db.Trials
                         where trial.CASE_STATUS.ToUpper().Contains("READY")
                         orderby trial.RULE_600 descending
                         select trial;

            var judges = from judgeCase in db.JudgeCaseStatus
                         select judgeCase;

            var currentTrials = trials.Where(t => judges.Any(j => t.ID.ToString() != j.CaseID));

            return currentTrials.ToList();
        }

        public List<Judge> GetJudges()
        {

            TrialStatusEntities1 db = new TrialStatusEntities1();
            var judges = from judgeCase in db.JudgeCaseStatus
                         select judgeCase;

            List<Judge> judgesList = new List<Judge>();

            foreach (JudgeCaseStatus judge in judges)
            {

            }
        }
    }
}