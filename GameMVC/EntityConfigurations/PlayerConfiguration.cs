using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using GameMVC.Models;

namespace GameMVC.EntityConfigurations
{
    public class PlayerConfiguration : EntityTypeConfiguration<Player>
    {
        public PlayerConfiguration()
        {
            //Configurations
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Lastname)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Birthdate)
                .IsRequired();

            Property(p => p.Passport)
                .IsRequired()
                .HasMaxLength(15);

            Property(p => p.Address)
                .IsOptional()
                .HasMaxLength(500);

            Property(p => p.Sex)
                .IsRequired()
                .HasMaxLength(1);

            Property(p => p.TeamId)
                .IsOptional();

            Property(p => p.StateId)
                .IsRequired();



        }

    }
}