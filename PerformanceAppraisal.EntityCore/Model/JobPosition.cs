using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class JobPosition : Base
    {
        public JobPosition()
        {
            Employees = new HashSet<Employee>();
            Skills = new HashSet<Skill>();
        }
        public int SkillId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}
