using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
   
    public class Artist
    {
        public int ArtistID { get; set; }
        [Required()]
        [StringLength(100,MinimumLength=2)]
        public string ArtistName { get; set; }

    }
}