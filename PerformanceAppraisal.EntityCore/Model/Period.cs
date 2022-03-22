using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class Period : Base
    {
        public Period()
        {
            WorkAnnualPlans = new HashSet<WorkAnnualPlan>();
        }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<WorkAnnualPlan> WorkAnnualPlans { get; set; }    
    }
}
