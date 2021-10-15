using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Keyboards.Modles;

    public class KeyboardContext : DbContext
    {
        public KeyboardContext (DbContextOptions<KeyboardContext> options)
            : base(options)
        {
        }

        public DbSet<Keyboards.Modles.Keyboard> Keyboard { get; set; }
    }
