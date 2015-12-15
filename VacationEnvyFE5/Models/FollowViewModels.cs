using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Models
{
    public class FollowersViewModel
    {
        public IList<ApplicationUser> Followers { get; set; }
    }

    public class FollowingViewModel
    {
        public IList<ApplicationUser> Followings { get; set; }
    }

    public class AllCountryAlbumViewModel
    {
        public IList<CountryAlbum> AllCountryAlbums { get; set; }
    }
}