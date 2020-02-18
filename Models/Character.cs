using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCharacter.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string CharacterName { get; set; }
        [Required]
        [Display(Name = "Class")]
        public string CharacterClass { get; set; }
        [Range(1, 250)]
        [Display(Name = "Attack")]
        public int Atk { get; set; }
        [Range(1, Int32.MaxValue)]
        public int HP { get; set; }
        [Range(1, 100)]
        public int AC { get; set; }
    }
}
