using Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable(name: "Address", schema: "dbo");
            builder.Property(x => x.Province).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.District).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.Street).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.ZipCode).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.Line).IsRequired(true).HasMaxLength(100);
        }
    }
}