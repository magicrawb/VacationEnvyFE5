using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
    //NOT DOING POST ANYMORE - DECIDED 7-15 MIDDAY - BY AC
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Description { get; set; }
        public DateTime DatePost { get; set; }

        public Nullable<int> CityAlbumId { get; set; }
        [ForeignKey("CityAlbumId")]
        public virtual CityAlbum CityAlbum { get; set; }

        public Nullable<int> PictureId { get; set; }              //added by ALC 7-14/nullable-not all posts have pictures
        [ForeignKey("PictureId")]
        public virtual Picture Picture { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }   //added by AC 7-14 per nakov.com/tag/asp-net-mvc/ tutorial
    }
}
