using Microsoft.EntityFrameworkCore;
using PontoEletronico.Funcionarios;
using PontoEletronico.Pontos;
using PontoEletronico.Setores;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace PontoEletronico.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class PontoEletronicoDbContext :
    AbpDbContext<PontoEletronicoDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }
    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }
    // Mine
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Setor> Setores { get; set; }
    public DbSet<Ponto> Pontos { get; set; }

    #endregion

    public PontoEletronicoDbContext(DbContextOptions<PontoEletronicoDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<Funcionario>(b =>
        {
            b.ToTable("Funcionarios");
            b.HasKey(x => x.Id);
            b.Property(x => x.Nome).IsRequired().HasMaxLength(128);
            b.Property(x => x.Sobrenome).IsRequired().HasMaxLength(128);
            b.Property(x => x.CPF).IsRequired().HasMaxLength(11);
            b.Property(x => x.Salario);
            b.Property(x => x.DataNascimento).IsRequired();
            b.HasOne<Setor>().WithMany().HasForeignKey(x => x.SetorId);
            b.ConfigureByConvention();
        });

        builder.Entity<Setor>(b =>
        {
            b.ToTable("Setores");
            b.HasKey(x => x.Id);
            b.Property(x => x.Nome).HasMaxLength(128).IsRequired();
            b.Property(x => x.Sala).HasMaxLength(128);
            b.ConfigureByConvention();
        });

        builder.Entity<Ponto>(b =>
        {
            b.ToTable("Pontos");
            b.HasKey(x => x.Id);
            b.Property(x => x.Modalidade).IsRequired();
            b.Property(x => x.Data).IsRequired();
            b.HasOne<Funcionario>().WithMany().HasForeignKey(x => x.FuncionarioId).IsRequired();
            b.ConfigureByConvention();
        });
    }
}
