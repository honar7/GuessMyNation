using GuessMyNation.Core.Domain.Nation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GuessMyNation.Infra.Data.Sql.Nations
{
    public  class NationConfig : IEntityTypeConfiguration<Nation>
    {
        public void Configure(EntityTypeBuilder<Nation> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);           
        }
    }
}
