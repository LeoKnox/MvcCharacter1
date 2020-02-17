using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCharacter.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string CharacterClass { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
    }
}
