using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Models
{
    public class ProfileViewModel // Profile VM for a registered user. Need tests.
    {
        [Key]
        public string Id { get; set; }          //added by Anna 7-19 to try to fix entity error for scaffold
        public string PicUrl { get; set; }
        public string ViewId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Biography { get; set; }
        public string Email { get; set; }
        public string HomeCity { get; set; }
        public string HomeCountry { get; set; }
        public int FollowerCount { get; set; }
        public int FollowingCount { get; set; }
        public int CountryCount { get; set; }
        public DateTime DateCreated { get; set; }

        //public int CountryAlbumId { get; set; }
        //[ForeignKey("CountryAlbumId")]
        public IList<CountryAlbum> CountryAlbums { get; set; }
        


        //ADDED BY ANNA - not definite - 7.16
        public string ToId { get; set; }
        [ForeignKey("ToId")]
        public IList<UserFollow> Followers { get; set; } 
        
        public int FromId { get; set; }
        [ForeignKey("FromId")]
        public IList<UserFollow> Following { get; set; }


        //public string FromId { get; set; } // This can be obtained by User.Identity.GetUserId() method. Removed by KI 07/18/15
      
        
    }

    public class CreateProfileViewModel // Profile VM for a registered user. Need tests.
    {
        public string Biography { get; set; }
        public string HomeCity { get; set; }
        public string HomeCountry { get; set; }
        public string Email { get; set; }
    }

    public class EditProfileViewModel // Profile VM for a registered user. Need tests.
    {
        [Key]
        public int EditId { get; set; }
        public string ViewId { get; set; }
        public string Biography { get; set; }
        public string HomeCity { get; set; }
        public string HomeCountry { get; set; }
        public string Email { get; set; }
        public string PicUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}