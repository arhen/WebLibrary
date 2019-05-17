using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Judul Tidak boleh lebih dari 100 Karakter")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "{0} minimal {2} dan maximal {1} karakter.", MinimumLength = 2)]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18,2")]
        public decimal Price { get; set; }
    }
}
