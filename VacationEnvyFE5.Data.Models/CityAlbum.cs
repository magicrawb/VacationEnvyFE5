using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
    public class CityAlbum
    {
        [Key]
        public int CityAlbumId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime DatePosted { get; set; }
        public DateTime DateUpdated { get; set; }

        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        public int CountryAlbumId { get; set; }                           // CountryAlbum FK added back by AC (7/14/15)
        [ForeignKey("CountryAlbumId")]
        public virtual CountryAlbum CountryAlbum { get; set; }

        //public int PictureId { get; set; }                          // PictureId FK added by KI 07/16/15   ---> commented out by AC 7-18 no single pictureId to a whole city album
        //[ForeignKey("Pictures")]
        public virtual ICollection<Picture> Pictures { get; set; }

        //public string UserId { get; set; }
        //public virtual ApplicationUser User { get; set; }         //commented out by AC 7-14

        //public virtual ICollection<Post> Posts { get; set; }        //DELETED by AC 7-15
       
        //public virtual ICollection<CityAlbumPicture> Pictures { get; set; }      //*updated/commented out by AC 7-15-nixed lookup table

        // Country FK removed by KI
        // ApplicationUser Id FK removed by KI
    }
}
