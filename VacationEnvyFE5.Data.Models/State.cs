using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }

        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }        // added by AC 7-14

        public virtual ICollection<City> Cities { get; set; }

        // FK removed by KI (07/10/15)
    }
}
