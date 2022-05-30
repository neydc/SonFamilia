using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SonFamilia.Models;

namespace SonFamilia.Database.Mapeo
{
    public class MapImagen : IEntityTypeConfiguration<Imagen>
    {
        public void Configure(EntityTypeBuilder<Imagen> builder)
        {
            builder.ToTable("Imagen");
            builder.HasKey(a=>a.Id);

        }
    }
}
