using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Crm.ApplicationCore.Entity;

namespace Crm.Infra.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext>  options ) : base(options) 
        {

        }
        public DbSet<Client> clients { get; set; }
        //Responsável pela configuração do framework
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clientes");
        }
    }
}
