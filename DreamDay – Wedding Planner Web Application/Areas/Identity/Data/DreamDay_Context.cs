using DreamDay___Wedding_Planner_Web_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DreamDay___Wedding_Planner_Web_Application.Areas.Identity.Data;

public class DreamDay_Context : IdentityDbContext<DreamDay_User>
{
    public DreamDay_Context(DbContextOptions<DreamDay_Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<DreamDay_User>
{
    public void Configure(EntityTypeBuilder<DreamDay_User> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        builder.Property(x => x.City).HasMaxLength(20);
        builder.Property(x => x.phone).HasMaxLength(10).IsRequired();

    }
}