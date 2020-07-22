using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApi.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Sala> Salas { get; set; }

        public DbSet<Evento> Eventos { get; set; }
        
        public override int SaveChanges()
        {


            return base.SaveChanges();
        }
    }
}
