using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Cursomvc;Integrated Security=True");
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Cursomvc;Integrated Security=true");
        }
    }
}
