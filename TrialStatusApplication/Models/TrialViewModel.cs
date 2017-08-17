using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrialStatusApplication.Models
{
    public class TrialViewModel
    {
        public string Judge { get; set; }
        public string Defendant { get; set; }
        public string Prosecutor { get; set; }
        public string DefenseAttorney { get; set; }
        public DateTime TrialDate { get; set; }

        public TrialViewModel(Trial _trial, Judge _judge)
        {
            Judge = _judge.JudgeName;
            Defendant = _trial.DEFENDANT_NAME;
            Prosecutor = _trial.PROSECUTOR;
            DefenseAttorney = _trial.DEFENSE_ATTORNEY;
            TrialDate = Convert.ToDateTime(_trial.RULE_600);
        }

    }
}