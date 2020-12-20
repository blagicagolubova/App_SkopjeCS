using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkopjeCS.Models
{
    public class Comments
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Komentari/Comments")]
        public String komentar { get; set; }
    }
}