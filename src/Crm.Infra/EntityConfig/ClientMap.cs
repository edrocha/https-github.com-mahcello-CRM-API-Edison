using Crm.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace Crm.Infra.EntityConfig
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            #region Configuração do Client

            builder.HasKey(c => c.cliID);
            builder.Property(e => e.cliNome)
                    .IsRequired()
                    .HasColumnType("varchar(200)");
            builder.Property(e => e.cliEmail)
                    .HasColumnType("varchar(100)");

            #endregion

        }


    }
}