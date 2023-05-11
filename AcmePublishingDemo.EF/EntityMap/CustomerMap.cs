using AcmePublishingDemo.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcmePublishingDemo.EF.EntityMap
{
    public partial class CustomerMap : EntityTypeConfiguration<CustomerEntity>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.ToTable(nameof(CustomerEntity));

            builder.HasMany(_ => _.Subscriptions)
                        .WithOne(_ => _.Customer)
                        .HasForeignKey(c => c.CustomerId)
                        .OnDelete(DeleteBehavior.Cascade);

            base.Configure(builder);
        }

        #endregion Methods
    }
}
