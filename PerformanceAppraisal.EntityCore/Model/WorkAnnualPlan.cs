using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class WorkAnnualPlan : Base
    {
        public WorkAnnualPlan()
        {
            Objectives = new HashSet<Objective>();
        }
        public int EmployeeId { get; set; }
        public int SupervisorId { get; set; }
        public int PeriodId { get; set; }
        public DateTime AppraisalLastDate { get; set; }
        public string FinalAppraisal { get; set; }
        public decimal? FinalPoints { get; set; }
        public bool? HasObjective { get; set; }

        public Employee Employee { get; set; }
        public Employee Supervisor { get; set; }
        public Period Period { get; set; }

        public ICollection<Objective> Objectives { get; set; }
    }
}
