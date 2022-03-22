using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class Objective : Base
    {
        public Objective()
        {
            Activities = new HashSet<Activity>();
        }
        public int WorkAnnualPlanId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Points { get; set; }
        public bool? HasActivities { get; set; }

        public virtual WorkAnnualPlan WorkAnnualPlan { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }

    }
}
