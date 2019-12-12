using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace study_cards_api.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Must include the word property.")]
        public string Word { get; set; }
        [Required(ErrorMessage = "Must include the definition property.")]
        public string Definition { get; set; }

        [ForeignKey(nameof(Stack))]
        public int StackId { get; set; }
        public Stack Stack { get; set; }
    }
}
