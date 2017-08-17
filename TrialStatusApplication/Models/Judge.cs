using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrialStatusApplication.Models
{
    public class Judge
    {
        public string JudgeName { get; set; }

        public Trial CurrentTrial { get; set; }

    }
}