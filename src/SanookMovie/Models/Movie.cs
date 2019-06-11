using System;
using System.ComponentModel.DataAnnotations;

namespace SanookMovie.Models {
    public class Movie {
        public int Id { set; get; }

        [Required]
        public string Title { set; get; }

        [Required]
        public string Genre { set; get; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { set; get; }
    }
}