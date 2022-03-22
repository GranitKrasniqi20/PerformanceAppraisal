using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class Base
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public DateTime DateInserted { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? CreatedBy { get; set; }  
        public int? UpdatedBy { get; set; }  
        public bool? Active { get; set; }
    }
}
