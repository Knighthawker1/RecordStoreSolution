using System;
using System.ComponentModel.DataAnnotations;

namespace RecordStoreProject.Models
{
    public class PartialClasses
    {
        [MetadataType(typeof(GenreMetadata))]
        public partial class Genre
        {

        }

        [MetadataType(typeof(ArtistMetadata))]
        public partial class Artist
        {

        }

        [MetadataType(typeof(AlbumMetadata))]
        public partial class Album
        {

        }
    }
}