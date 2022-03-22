using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class Employee : Base
    {
        public Employee()
        {
            JobPositions = new HashSet<JobPosition>();
            WorkAnnualPlanForEmployees = new HashSet<WorkAnnualPlan>();
            WorkAnnualPlanForSupervisors = new HashSet<WorkAnnualPlan>();
        }
        public int PersonId { get; set; }
        public string EmployeeNumber { get; set; }
        public virtual Person Person { get; set; }

        public virtual ICollection<JobPosition> JobPositions { get; set; }
        public virtual ICollection<WorkAnnualPlan> WorkAnnualPlanForEmployees { get; set; }
        public virtual ICollection<WorkAnnualPlan> WorkAnnualPlanForSupervisors { get; set; }
    }
}
