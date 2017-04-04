using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
        
        public string Author { get; set; }

        [Required]
        public string Body { get; set; }
    
        public DateTime Posted { get; set; }

    }
}
