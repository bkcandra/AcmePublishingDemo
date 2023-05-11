using AcmePublishingDemo.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcmePublishingDemo.EF.EntityMap
{
    public partial class CustomerSubscriptionMap : EntityTypeConfiguration<CustomerSubscriptionEntity>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CustomerSubscriptionEntity> builder)
        {
            builder.ToTable(nameof(CustomerSubscriptionEntity));

            builder.HasMany(_ => _.DeliveryAddresses)
                        .WithOne(_ => _.Subscription)
                        .HasForeignKey(x => x.SubscriptionId)
                        .OnDelete(DeleteBehavior.Cascade);

            base.Configure(builder);
        }

        #endregion Methods
    }
}
