using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TableTopCharacterManager.Models
{
    public class TableTopCharacterManagerContext : DbContext
    {
        public TableTopCharacterManagerContext (DbContextOptions<TableTopCharacterManagerContext> options)
            : base(options)
        {
        }

        public DbSet<TableTopCharacterManager.Models.Character> Character { get; set; }
    }
}
