using System;
using System.ComponentModel.DataAnnotations;

namespace RecordStoreProject.Models
{
    public class GenreMetadata
    {
        [StringLength(50)]
        [Required(ErrorMessage = "A genre is required")]
        [Display(Name = "Genre name")]
        public string GenreName;
    }
    public class ArtistMetadata
    {
        [StringLength(100)]
        [Required(ErrorMessage = "An artist name is required")]
        [Display(Name = "Artist name")]
        public string ArtistName;
    }
    public class AlbumMetadata
    {
        [StringLength(100)]
        [Required(ErrorMessage = "An album name is required")]
        [Display(Name = "Album name")]
        public string AlbumName;

        [Range(1, 100, ErrorMessage = "Album price must be between 1 and 100")]
        [Display(Name = "Album Price")]
        public decimal AlbumPrice;
    }
}