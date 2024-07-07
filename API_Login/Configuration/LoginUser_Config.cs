using API_Login.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Login.Configuration
{
    public class LoginUser_Config : IEntityTypeConfiguration<LoginUser_mdl>
    {
        public void Configure(EntityTypeBuilder<LoginUser_mdl> builder) {

            _ = builder.ToTable("LoginUser");
            _ = builder.Property(x => x.UserId).HasColumnName("UserId").HasColumnType("int").IsRequired();
            _= builder.HasKey(x => x.UserId);
            _= builder.Property(x =>x.UserName).HasColumnName("UserName").HasColumnType("varchar(250)");
            _ = builder.Property(x => x.Password).HasColumnName("Password").HasColumnType("varchar(250)");
            _ = builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("varchar(250)");
            _ = builder.Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").HasColumnType("varchar(250)");
            _ = builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("varchar(250)");
            _ = builder.Property(x => x.Dob).HasColumnName("Dob").HasColumnType("datetime");
            _ = builder.Property(x => x.IsActive).HasColumnName("IsActive").HasColumnType("bit");
            _ = builder.Property(x => x.IsDeleted).HasColumnName("IsDeleted").HasColumnType("bit");
            _ = builder.Property(x => x.Department).HasColumnName("Department").HasColumnType("varchar(250)");
            _ = builder.Property(x => x.CreatedBy).HasColumnName("CreatedBy").HasColumnType("varchar(250)");
            _ = builder.Property(x => x.Created).HasColumnName("Created").HasColumnType("datetime");
            _ = builder.Property(x => x.LastModifiedBy).HasColumnName("LastModifiedBy").HasColumnType("datetime");
            _ = builder.HasOne(x=> x.AdminRole).WithMany(x=> x.LoginUsers).HasForeignKey(x => x.RoleId);
            _ = builder.Property(x => x.RoleKey).HasColumnName("RoleKey").HasColumnType("BIGINT");
        }

    }
}
