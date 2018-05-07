using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCollections.Models
{
    public enum Category
    {
        aksion, drama, romance, education
    }
    public class Books
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Autor Name")]
        public string Author { get; set; }
        [Required]
        [MaxLength(80)]
        public string Description { get; set; }
        [Required]
        public Category Category { get; set; }

         
            
          
       
       
    }

}
