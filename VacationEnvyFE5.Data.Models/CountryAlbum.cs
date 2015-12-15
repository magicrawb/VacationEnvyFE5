using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
    public class CountryAlbum
    {
        [Key]
        public int CountryAlbumId { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateUpdated { get; set; }

        public int CountryId { get; set; }
        //[ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

       
        public virtual ICollection<CityAlbum> CityAlbums { get; set; } //this allows you to see what city albums are within each country album - AC 7-14

        public string UserId { get; set; }
        [ForeignKey("UserId")]  // Put back by KI 07/19/15
        //[InverseProperty("")]
        public virtual ApplicationUser User { get; set; }           //ApplicationUser added back by ALC 7-15 for 1-to-many rel with countryalbums
        public CountryAlbum()
        {
            //this.CityAlbums = new HashSet<CityAlbum>();           //not sure if necessary after using iCollection above - AC 7-18
            this.DatePosted = DateTime.Now;
        }
        //public int CityAlbumId { get; set; }                  //commented out by ALC 7-14/no FK needed
        //[ForeignKey("CityAlbumId")]
    }
}
