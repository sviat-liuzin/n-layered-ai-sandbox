using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedPanda.NLayered.Domain.Map;

namespace RedPanda.NLayered.Data.Sql.Mappings;

public class MyMapMappingConfiguration : IEntityTypeConfiguration<MyMap>
{
    public void Configure(EntityTypeBuilder<MyMap> builder)
    {
        builder.ToTable("MyMaps");

        builder
            .HasKey(i => i.Id);

        builder
            .Property(i => i.CurrentForecast)
            .IsRequired()
            .HasMaxLength(300);
    }
}