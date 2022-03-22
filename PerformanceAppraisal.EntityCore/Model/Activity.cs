using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class Activity : Base
    {
        public Activity()
        {
            AppraisalActivities = new HashSet<AppraisalActivity>();
        }
        public int ObjectiveId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Weight { get; set; }

        public virtual Objective Objective { get; set; }
        public virtual ICollection<AppraisalActivity> AppraisalActivities { get; set; }

    }
}
