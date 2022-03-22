using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class AppraisalActivity : Base
    {
        public int ActivityId { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsCompleted { get; set; }
        public bool HasPenalty { get; set; }
        public int Points { get; set; }

        public virtual Activity Activity { get; set; }

    }
}
