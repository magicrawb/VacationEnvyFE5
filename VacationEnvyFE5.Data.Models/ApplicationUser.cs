using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace VacationEnvyFE5.Data.Models
{
        public class ApplicationUser : IdentityUser
        {
            public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
            {
                // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
                var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
                // Add custom user claims here
                return userIdentity;
            }


            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Biography { get; set; }

            //public int PicId { get; set; }                        //added for prof pic - was testing - Anna 7-20 end of night
            //[ForeignKey("PicId")]
            //public virtual Picture ProfPicture { get; set; }

            //public string Website { get; set; }       //commented out by Anna b/c it messed up database - can add if we need to redo database
            

            [Column(TypeName = "datetime2")]            //ADDED SQL DATETIME2 TYPES - ALC 7-13
            public DateTime DateCreated
            {
                get                                     //solution for datetime2 error//makes date created equal to current time of reg. - BY ALC 7-13
                {
                    return this.dateCreated.HasValue
                        ? this.dateCreated.Value
                        : DateTime.Now;
                }

                set { this.dateCreated = value; }
            }
            private DateTime? dateCreated = null;


            [Column(TypeName = "datetime2")]
            public DateTime Birthday { get; set; }

            public Nullable<int> CityId { get; set; }
            [ForeignKey("CityId")]
            public virtual City City { get; set; }

            public Nullable<int> CountryId { get; set; }
            [ForeignKey("CountryId")]
            public virtual Country Country { get; set; }

            public virtual ICollection<UserFollow> FromUser { get; set; }     //*added by AC 7-15 see all user's follows
            public virtual ICollection<UserFollow> ToUser { get; set; }      //*added by AC 7-15 see all user's follows

            public virtual ICollection<CountryAlbum> CountryAlbums { get; set; }        //added by AC 7-15 to show all user's albums

            public Gender Gender { get; set; }

        }
    public enum Gender                                  //added 7-14 by AC for enum dropdown
    {
        Female,
        Male
    }
}

