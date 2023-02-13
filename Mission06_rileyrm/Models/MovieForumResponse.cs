using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_rileyrm.Models
{
    public class MovieForumResponse
    {
        [Key]
        [Required]
        public int MovieForumID { get; set; }
        [Required(ErrorMessage = "The Category field is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Year field is required.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "The Director field is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "The Rating field is required.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
