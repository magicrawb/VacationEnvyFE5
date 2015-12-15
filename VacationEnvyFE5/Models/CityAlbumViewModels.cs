using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Models
{
    public class CityAlbumViewModel
    {
        [Key]
        public int CityAlbumId { get; set; }                        //added b/c of error AC 7-18    
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int CountryAlbumId { get; set; }
        public string CityAlbumTitle { get; set; }
        public string CityDescription { get; set; }        
        public IList<PictureViewModel> Pictures { get; set; }
        //public IList<Picture> PictureList { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UrlName { get; set; }
        public PictureViewModel pVm { get; set; }
        public IList<Picture> ListOfPics { get; set; }  
    }

    public class CreatePictureViewModel                             // ViewModel used to create a picture
    {
        public int PictureId { get; set; }
        public string UrlName { get; set; }
        public string Caption { get; set; }            
        public string TagName { get; set; }    
        public bool IsCityCoverPic { get; set; }
        public bool IsCountryCoverPic { get; set; }
        public int CountryAlbumId { get; set; } 
        public int CityAlbumId { get; set; } 
    }

    public class EditPictureViewModel                               // ViewModel used to edit a picture
    {
        public int PictureId { get; set; }
        public string Caption { get; set; }
        public string TagName { get; set; }
        public bool IsCityCoverPic { get; set; }
        public bool IsCountryCoverPic { get; set; }
    }
}