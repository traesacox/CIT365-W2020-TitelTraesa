using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength =3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]//Value types are required so don't need the required attribute
        public DateTime ReleaseDate { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]//Value types are required so don't need the required attribute
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18,2)")]//enables Entity Framework Core to correctly map Price to currrency in DB
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'/s-]*$")]
        [StringLength(5)]
        [Required]
        [NotMapped]
        public string Rating { get; set; }
    }
}
