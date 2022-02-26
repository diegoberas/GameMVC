using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using GameMVC.Models;

namespace GameMVC.EntityConfigurations
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Alpha2)
                .IsRequired()
                .HasMaxLength(2);

            Property(c => c.Alpha3)
                .IsRequired()
                .HasMaxLength(3);

            Property(c => c.NumericCode)
                .IsRequired();

            Property(c => c.Iso)
                .IsRequired()
                .HasMaxLength(13);


            HasMany(t => t.Teams)
                .WithRequired(c => c.Country)
                .HasForeignKey(c => c.CountryId)
                .WillCascadeOnDelete(false);

        }
    }
}