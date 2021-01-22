using Contexto.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Contexto.Data
{
    public class SistemaContext : DbContext
    {
        public SistemaContext(DbContextOptions<SistemaContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasData(new List<Usuario>(){
                new Usuario(1, "teste@teste.com", "123", "primeiro nm", "nm completo", "end", "compl", 1, "cidade nv", "rj", "12345", "M")
            });
        }
    }
}
