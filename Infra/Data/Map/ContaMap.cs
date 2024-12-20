using ClienteCRUD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClienteCRUD.Data.Map
{
    public class ContaMap : IEntityTypeConfiguration<ContaModel>
    {
        public void Configure(EntityTypeBuilder<ContaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Agencia).IsRequired();
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Status).IsRequired();

        }
    }
}