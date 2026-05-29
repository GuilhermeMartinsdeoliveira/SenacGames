using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenacGames.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Infrastructure.Configurations
{
    internal class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Title)
                .IsRequired() // define que o campo é obrigatorio
                .HasMaxLength(200); //define o tamanho maximo

            builder.Property(g => g.Description)
                .HasMaxLength(200);// tamnho maximo 

            builder.Property(g => g.CoverImageUrl)
                .HasMaxLength (500);

            builder.HasOne(g => g.Category) //um game tem uma categoria 
                .WithMany(c => c.Games) // uma categoria te muitos games
                .HasForeignKey(g => g.CategoryId) // a FK e CategoryId
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
