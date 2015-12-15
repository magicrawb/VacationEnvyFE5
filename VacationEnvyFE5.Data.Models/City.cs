using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        // Added State FK by KI (07/10/15)
        public Nullable<int> StateId { get; set; }          //added Nullable for stateless cities 7-14 AC
        [ForeignKey("StateId")]
        public virtual State State { get; set; }

        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }            //added by AC 7-14


        public virtual ICollection<CityAlbum> CityAlbums { get; set; }  //added by AC 7-14 for search by city function
        // Removed CountryId FK by KI
    }
}
