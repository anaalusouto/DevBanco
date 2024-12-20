using ClienteCRUD.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClienteCRUD.Data.Map
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Cellphone).IsRequired().HasMaxLength(14);
            builder.Property(x => x.Data_Nascimento).IsRequired();

        }
    }
}
