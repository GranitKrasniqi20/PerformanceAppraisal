using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class Skill : Base
    {
        public Skill()
        {
            JobPositions = new HashSet<JobPosition>();
        }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<JobPosition> JobPositions { get; set; }
    }
}

