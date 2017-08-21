﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrialStatusApplication.Models;

namespace TrialStatusApplication.DatabaseQueries
{
    public class TrialInfoQueries
    {

        internal List<Trial> GetTrials()
        {
            TrialStatusEntities1 db = new TrialStatusEntities1();
            var trials = from trial in db.Trials
                         where trial.CASE_STATUS.ToUpper().Contains("READY")
                         orderby trial.RULE_600 descending
                         select trial;

            var judges = from judgeCase in db.JudgeCaseStatus1 select judgeCase;

            var currentTrials = trials.Where(t => judges.Any(j => t.ID.ToString() != j.CaseID));

            return currentTrials.ToList();
        }

        internal List<Judge> GetJudgesAndStatus()
        {

            TrialStatusEntities1 db = new TrialStatusEntities1();
            var judges = from judgeCase in db.JudgeCaseStatus1
                         select judgeCase;

            var trials = from trial in db.Trials
                         select trial;

            var judgeNames = from judgeIntials in db.JudgeName_XRef
                             select judgeIntials;

            List<Judge> judgesList = new List<Judge>();

            foreach (JudgeCaseStatus judge in judges)
            {
                var foundTrial = from trial in trials
                             where trial.ID.ToString() == judge.CaseID
                             select trial;

                var judgeName = from judgeIntials in judgeNames
                                 where judgeIntials.JudgeIntials == judge.Judge
                                 select judgeIntials;


                judgesList.Add(new Judge { CurrentTrial = foundTrial.FirstOrDefault(), JudgeName = judgeName.FirstOrDefault().JudgeName, Status = judge.Status });
            }

            return judgesList;
        }

        internal void UpdateJudges(List<Judge> judgesUpdates)
        {
            TrialStatusEntities1 db = new TrialStatusEntities1();

            List<JudgeCaseStatus> judges = (from judge in db.JudgeCaseStatus1
                                  select judge).ToList();

            foreach (Judge updateJudge in judgesUpdates)
            {
                JudgeCaseStatus judgeToUpdate = (from j in judges
                                                 where j.CaseID == updateJudge.CurrentTrial.CASE_NUMBER).FirstOrDefault();

                judgeToUpdate.Status = updateJudge.Status;
            }

            db.SaveChanges();
        }

        internal void UpdateTrials(List<Trial> updatedTrials)
        {
            TrialStatusEntities1 db = new TrialStatusEntities1();

            List<Trial> trials = (from trial in db.Trials
                                 select trial).ToList();

            foreach (Trial trialUpdate in updatedTrials)
            {
                Trial trialToUpdate = (from t in trials
                                      where t.ID == trialUpdate.ID
                                      select t).FirstOrDefault();
                trialToUpdate.JUDGE = trialUpdate.JUDGE;
            }

            db.SaveChanges();
        }
    }
}