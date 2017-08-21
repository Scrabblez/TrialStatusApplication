using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrialStatusApplication.Models
{
    public class AdministratorViewModel
    {
        public List<Trial> Trials { get; set; }
        public List<Judge> Judges { get; set; }
        public AdminUser User { get; set; }
        public Statuses Statuses { get; set; }
    }
}