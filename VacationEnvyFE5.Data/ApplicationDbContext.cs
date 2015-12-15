using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = false;            
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public IDbSet<Country> Countries { get; set; }
        public IDbSet<CountryAlbum> CountryAlbums { get; set; }
        public IDbSet<City> Cities { get; set; }
        public IDbSet<CityAlbum> CityAlbums { get; set; }
        public IDbSet<State> States { get; set; }
        public IDbSet<Picture> Pictures { get; set; }
        public IDbSet<UserFollow> UserFollows { get; set; }

    }
}
