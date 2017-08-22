using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrialStatusApplication.Models
{
    public class Statuses
    {

        //public List<SelectListItem> StatusList { get; set; }

        //public Statuses()
        //{
        //    StatusList = new List<SelectListItem>();
        //    StatusList.Add(new SelectListItem { Text = "Commonwealth's Case", Value = "Commonwealth's Case" });
        //    StatusList.Add(new SelectListItem { Text = "Closing Statements", Value = "Closing Statements" });
        //    StatusList.Add(new SelectListItem { Text = "Defense Case", Value = "Defense Case" });
        //    StatusList.Add(new SelectListItem { Text = "Jury Instructions", Value = "Jury Instructions" });
        //    StatusList.Add(new SelectListItem { Text = "Opening Statement", Value = "Opening Statement" });
        //    StatusList.Add(new SelectListItem { Text = "Verdict", Value = "Verdict" });
        //    StatusList.Add(new SelectListItem { Text = "Voire Dire", Value = "Voire Dire" });
        //}

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