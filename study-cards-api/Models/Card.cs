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
        public int CardStackId { get; set; }
        public string Word { get; set; }
        public string Definition { get; set; }
        [ForeignKey(nameof(Stack))]
        public int StackId { get; set; }
        public Stack Stack { get; set; }
    }
}
