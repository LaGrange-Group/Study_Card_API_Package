using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace study_cards_api.Models
{
    public class Stack
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Must include a title property.")]
        public string Title { get; set; }
    }
}
