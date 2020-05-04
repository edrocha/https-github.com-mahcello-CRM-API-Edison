using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Crm.ApplicationCore.Entity;
using Crm.Infra.EntityConfig;

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

            #region Configuração do Client
              modelBuilder.Entity<Client>().ToTable("Clientes");
              modelBuilder.ApplyConfiguration(new ClientMap());
           #endregion
        }
    }
}
