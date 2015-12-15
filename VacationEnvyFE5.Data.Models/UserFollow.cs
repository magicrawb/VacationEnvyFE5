using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
    public class UserFollow
    {                                               //This is a lookup table - many to many
        [Key]
        public int UserFollowId { get; set; }       //changed to int because column isnt a guid - AC 7-15

        //*Inverse properties updated by AC 7-15
        public string FromId { get; set; }
        [ForeignKey("FromId")]
        [InverseProperty("ToUser")]
        public virtual ApplicationUser FromUser { get; set; }

        public string ToId { get; set; }
        [ForeignKey("ToId")]
        [InverseProperty("FromUser")]
        public virtual ApplicationUser ToUser { get; set; }

       
    }

   
}
