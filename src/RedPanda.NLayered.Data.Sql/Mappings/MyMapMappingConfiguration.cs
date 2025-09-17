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
            .HasKey(i => new { i.Id, i.Date });

        builder
            .Property(i => i.Date)
            .IsRequired();

        builder
            .Property(i => i.MapData)
            .IsRequired()
            .HasMaxLength(300);

        builder
            .Property(i => i.LastReportedTemperatureC)
            .IsRequired(false);
    }
}