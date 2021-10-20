using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Keyboards.Models;

    public class KeyboardContext : DbContext
    {
        public KeyboardContext (DbContextOptions<KeyboardContext> options)
            : base(options)
        {
        }

        public DbSet<Keyboards.Models.Keyboard> Keyboard { get; set; }
    }
