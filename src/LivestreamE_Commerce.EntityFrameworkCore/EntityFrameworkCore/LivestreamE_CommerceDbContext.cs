using LivestreamE_Commerce.Model.Goods;
using LivestreamE_Commerce.Model.RBAC;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace LivestreamE_Commerce.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class LivestreamE_CommerceDbContext :
        AbpDbContext<LivestreamE_CommerceDbContext>,
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

        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion

        #region 新建RBAC实体
        public DbSet<LogModel> LogModel { get; set; }
        public DbSet<MenuModel> MenuModel { get; set; }
        public DbSet<OrganizationModel> OrganizationModel { get; set; }
        public DbSet<RoleMenuModel> RoleMenuModel { get; set; }
        public DbSet<RoleModel> RoleModel { get; set; }
        public DbSet<UserModel> UserModel { get; set; }
        public DbSet<UserRoleModel> UserRoleFinder { get; set; }

        #endregion
        #region 新建Goods实体
        public DbSet<GoodsModel> GoodsModel { get; set; }
        public DbSet<GoodsImgModel> GoodsImgModel { get; set; }
        public DbSet<GoodsSpecificationModel> GoodsSpecificationModel { get; set; }
        public DbSet<GoodsTypeModel> GoodsTypeModel { get; set; }
        public DbSet<ImgModel> ImgModel { get; set; }
        public DbSet<IndentModel> IndentModel { get; set; }
        public DbSet<IndentDetailModel> IndentDetailModel { get; set; }
        public DbSet<SiteModel> SiteModel { get; set; }
        public DbSet<SpecificationModel> SpecificationModel { get; set; }
        public DbSet<UserImgModel> UserImgModel { get; set; }

        #endregion

        public LivestreamE_CommerceDbContext(DbContextOptions<LivestreamE_CommerceDbContext> options)
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
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LivestreamE_CommerceConsts.DbTablePrefix + "YourEntities", LivestreamE_CommerceConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //builder.Entity<GoodsImgModel>(b =>
            //{
            //    b.ToTable("GoodsImgModel");
            //    b.ConfigureByConvention();
            //});
        }
    }
}