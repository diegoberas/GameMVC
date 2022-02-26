using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading;
using System.Web;
using GameMVC.Models;

namespace GameMVC.EntityConfigurations
{
    public class TeamConfiguration : EntityTypeConfiguration<Team>
    {
        public TeamConfiguration()
        {
            HasKey(c => c.Id);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.CreationDate)
                .IsRequired();

            Property(t => t.CountryId)
                .IsRequired();

            Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(20);

            HasMany(c => c.Players)
                .WithOptional(p => p.Team)
                .HasForeignKey(p => p.TeamId)
                .WillCascadeOnDelete(false);


        }
    }
}