using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesProject.Model
{
    public class Book
    {
        [Key] // by that we dont have to pass ID. it will take it automatically.
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
