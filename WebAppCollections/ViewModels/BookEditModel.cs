using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAppCollections.Models;

namespace WebAppCollections.ViewModels
{
    public class BookEditModel
    {
        [Required]
        [Display(Name = "Autor Name")]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [MaxLength(80)]
        public string Description { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}
