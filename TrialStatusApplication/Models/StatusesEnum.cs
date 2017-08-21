using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrialStatusApplication.Models
{
    public class Statuses
    {
        public List<string> StatusList { get; set; }

        public Statuses()
        {
            StatusList = new List<string>();
            StatusList.Add("Commonwealth's Case");
            StatusList.Add("Closing Statements");
            StatusList.Add("Defense Case");
            StatusList.Add("Jury Instructions");
            StatusList.Add("Opening Statements");
            StatusList.Add("Verdict");
            StatusList.Add("Voire Dire");
        }
    }
}