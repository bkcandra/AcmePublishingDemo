
using AcmePublishingDemo.EF.Entities;
using AcmePublishingDemo.EF.Interface;
using AcmePublishingDemo.Infrastructure.Config;
using AcmePublishingDemo.Repository.Interface;
using AcmePublishingDemo.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Data;
using System.Reflection;
using System.Security.Claims;

namespace AcmePublishingDemo.EF
{

    public class EFContext : DbContext, IDbContext
    {
        public EFContext()
        {
        }

        public EFContext(DbContextOptions<EFContext> options)
           : base(options)
        {
        }


        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<CustomerSubscriptionEntity> Subscriptions { get; set; }
        public DbSet<PublicationEntity> Publications { get; set; }
        public DbSet<DeliveryAddressEntity> DeliveryAddresses { get; set; }
        public DbSet<DistributionCompanyEntity> PrintDistributionCompanies { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }

        #region Methods

        /// <summary>
        /// Further configuration the model
        /// </summary>
        /// <param name="modelBuilder">
        /// The builder being used to construct the model for this context
        /// </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // dynamically load all entity and query type configurations
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes().Where(
                type => (type.BaseType?.IsGenericType ?? false)
                        && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var typeConfiguration in typeConfigurations)
            {
                var configuration = (IMappingConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Commit trasnaction.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public async Task<int> CommitAsync()
        {
            AddTimeStamps();
            try
            {
                return await base.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return 0;
            }
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Initialise()
        {
            this.Database.Migrate();
        }

        #endregion Methods 

        #region Private

        /// <summary>
        /// The add time stamps.
        /// </summary>
        private void AddTimeStamps()
        {
            var entities = ChangeTracker.Entries().Where(
                e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));
            foreach (var entity in entities)
            {
                var id = (Thread.CurrentPrincipal as ClaimsPrincipal)?.Claims.FirstOrDefault(c => c.Type == "name")
                         ?.Value ?? "Dev";
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedUtc = DateTime.Now.ToUniversalTime();
                    ((BaseEntity)entity.Entity).CreatedBy = 1;
                }

                ((BaseEntity)entity.Entity).ModifiedUtc = DateTime.Now.ToUniversalTime();
                ((BaseEntity)entity.Entity).ModifiedBy = 1;
            }
        }

        public void Initialise(AppRegion region)
        {
        }

        #endregion Private
    }
}
