using API_Login.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Login.Configuration
{
    public class AdminRole_Config : IEntityTypeConfiguration<AdminRole_mdl>
    {
        public void Configure(EntityTypeBuilder<AdminRole_mdl> builder)
        {
        _ = builder.ToTable("AdminRole");
        _= builder.Property(x => x.RoleId).HasColumnName("RoleId").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
        _ = builder.HasKey(x => x.RoleId);
        _ = builder.Property(x => x.RoleName).HasColumnName("RoleName").HasColumnType("varchar(250)").IsRequired();
        _ = builder.Property(x => x.RoleDescription).HasColumnName("RoleDescription").HasColumnType("varchar(250)").IsRequired();
        _ = builder.Property(x => x.IsDeleted).HasColumnName("IsDeleted").HasColumnType("bit").IsRequired();
        }
    }
}
