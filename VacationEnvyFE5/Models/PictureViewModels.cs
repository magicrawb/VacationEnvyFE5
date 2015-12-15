using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Models
{
    public class PictureViewModel
    {
        
        public int PictureId { get; set; }
        public CountryAlbum Country { get; set; }
        public CityAlbum CityAlbum { get; set; }
        public string UrlName { get; set; }
        public string PictureCaption { get; set; }
        public int CityId { get; set; }

    }

}
