using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SonFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Database.Mapeo
{
    public class MapPost : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");
            builder.HasKey(a=>a.Id);

            builder.HasMany(a => a.ListImagenes).WithOne(a => a.Post).HasForeignKey(a => a.PostId);

        }
    }
}
