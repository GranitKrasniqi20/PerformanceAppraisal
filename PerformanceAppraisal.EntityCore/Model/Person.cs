using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore.Model
{
    public class Person : Base
    {
        public Person()
        {
            Employees = new HashSet<Employee>();
        }
        public string PersonalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlaceOfBirth { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsDisabled { get; set; }
        public DateTime? Birthday { get; set; }
        public int? GenderId { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? EthnicityId { get; set; }
        public int? CitizenshipId { get; set; }
        public int? BirthMunicipalityId { get; set; }
        public int? LanguageId { get; set; }
        public bool? Smoker { get; set; }
        public string? ImagePath { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
