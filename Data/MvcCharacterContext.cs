using System;
using Microsoft.EntityFrameworkCore;
using MvcCharacter.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCharacter.Data
{
    public class MvcCharacterContext : DbContext
    {
        public MvcCharacterContext (DbContextOptions<MvcCharacterContext> options) : base(options)
        {
        }

        public DbSet<Character> Character { get; set; }
    }
}
