using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using GameMVC.Models;

namespace GameMVC.EntityConfigurations
{
    public class StateConfiguration : EntityTypeConfiguration<State>
    {
        public StateConfiguration()
        {
            HasKey(s => s.Id);

            Property(s => s.NameState)
                .IsRequired()
                .HasMaxLength(50);

            Property(s => s.CreationDate)
                .IsRequired();


            HasMany(p => p.Players)
                .WithRequired(s => s.State)
                .HasForeignKey(s => s.StateId)
                .WillCascadeOnDelete(false);



        }
    }
}