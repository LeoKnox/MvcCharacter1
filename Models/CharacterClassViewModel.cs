using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcCharacter.Models
{
    public class CharacterClassViewModel
    {
        public List<Character> Characters { get; set; }
        public SelectList Classes { get; set; }
        public string CharacterClass { get; set; }
        public string SearchString { get; set; }
    }
}
