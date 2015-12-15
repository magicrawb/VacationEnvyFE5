using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<City> Cities { get; set; }   //added by ALC 7-14 - lets you get a list of cities per the country

        public virtual ICollection<CountryAlbum> CountryAlbums { get; set; } //added by AC 7-14 for search by city function

        public virtual ICollection<State> States { get; set; }          //added by AC 7-14

        // FK removed by KI (07/10/15)
    }
}
