using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Models
{
    public class VacationsSectionViewModel
    {
        public int CountryAlbumId { get; set; }
        public ICollection<CountryAlbum> CountryAlbums { get; set; }
    }
}