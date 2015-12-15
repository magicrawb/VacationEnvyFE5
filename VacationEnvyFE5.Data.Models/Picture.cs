using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
    public class Picture
    {
        [Key]
        public int PictureId { get; set; }
        public string UrlName { get; set; }                 
        public string Caption { get; set; }                     //added by AC per KI 7-15
   
        public string TagName { get; set; }                                     //added by AC 7-15 - made nullable on 7-18
        public bool IsCityCoverPic { get; set; }
        public bool IsCountryCoverPic { get; set; }

        //public Nullable<int> PostId { get; set; }       //not every picture is associated with a post/nullable - AC 7-14
        //[ForeignKey("PostId")]                           //commented out by AC 7-14 post grabs picture instead 
        //public virtual Post Post { get; set; }

        public int CountryAlbumId { get; set; }             //added back 7-16 AC
        [ForeignKey("CountryAlbumId")]
        public virtual CountryAlbum CountryAlbum { get; set; }

        public int CityAlbumId { get; set; }                //FK added back by ALC 7-14 and deleted by AC 7-14-lookup table instead
        [ForeignKey("CityAlbumId")]                         //FK ADDED BACK 7-15 by AC - nixed lookup table
        public virtual CityAlbum CityAlbum { get; set; }
    }
}
