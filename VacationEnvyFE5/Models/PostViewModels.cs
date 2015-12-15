using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using VacationEnvyFE5.Data.Models;

namespace VacationEnvyFE5.Models
{
    public class PostIndexViewModel
    {
        public string Description { get; set; }
        public DateTime DatePost { get; set; }

        // We will need a picture (nullable?) KI 07/14/15
    }
}