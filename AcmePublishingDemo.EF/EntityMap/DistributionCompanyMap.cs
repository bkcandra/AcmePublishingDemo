using AcmePublishingDemo.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcmePublishingDemo.EF.EntityMap
{
    public partial class DistributionCompanyMap : EntityTypeConfiguration<DistributionCompanyEntity>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<DistributionCompanyEntity> builder)
        {
            builder.ToTable(nameof(DistributionCompanyEntity));

            builder.HasMany(_ => _.Publications)
                        .WithMany(_ => _.DistributionCompanies);

            base.Configure(builder);
        }

        #endregion Methods
    }
}
