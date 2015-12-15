using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VacationEnvyFE5.Data.Models;


namespace VacationEnvyFE5.Models
{
    public class CountryAlbumViewModel
    {
        [Key]
        public int CountryAlbumId { get; set; }                             //added by anna to fix entity error
        public IList<ListCityAlbumViewModel> CityAlbumsFromVM { get; set; }
        public string CountryName { get; set; }             //need
        public int CityAlbumCount { get; set; }         //need
        public IList<CityAlbum> CityAlbums { get; set; }           //added by Anna - corresponds with line I added/playing with/commented out on countryAlbumController - also added keys to this, can delete if you want.
        //public string CityAlbumCover { get; set; }    //added by anna to test with 7-19//need
        public string CountryAlbumDescription { get; set; }                 //added by AC 7-20//need
        public ProfileViewModel profile { get; set; }
        public string CityAlbumTitle { get; set; }              // added city album title by AC 7-21//need
        public string CityName { get; set; }                    //need
        public string StateName { get; set; }                   //need
        public int PictureId { get; set; }
        
    }

    public class ListCityAlbumViewModel
    {
        [Key]
        public int CityAlbumId { get; set; }
        public string Description { get; set; }
        public string CityCoverUrl { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public IList<Picture> Pictures { get; set; }

    }

    public class CreateCityAlbumViewModel
    {
        public int CityAlbumId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public int CityId { get; set; }
        public int CountryAlbumId { get; set; }
    }

    public class EditCityAlbumViewModel
    {
        public int CityAlbumId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateUpdated { get; set; }        
    }

    public class CreateCountryAlbumViewModel
    {
        public int CountryAlbumId { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public int CountryId { get; set; }
        public string Id { get; set; }
    }

}