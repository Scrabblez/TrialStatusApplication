using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrialStatusApplication.Models
{
    public class CurrentTrialsViewModel
    {

        public List<Trial> UpcomingTrials { get; set; }
        public List<Judge> MyProperty { get; set; }
    }
}