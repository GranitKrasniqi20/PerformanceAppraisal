using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class AppraisalSkill : Base
    {
        public int SkillId { get; set; }
        public int Points { get; set; }
        public string? Comment { get; set; }
        public DateTime AppraisalLastDate { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
