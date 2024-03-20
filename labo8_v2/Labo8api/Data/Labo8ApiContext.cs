using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Labo8Api.Models;

namespace Labo8Api.Data
{
    public class Labo8ApiContext : DbContext
    {
        public Labo8ApiContext (DbContextOptions<Labo8ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Labo8Api.Models.Animal> Animal { get; set; } = default!;
    }
}
