using AcmePublishingDemo.Repository.Models;

namespace AcmePublishingDemo.EF.Entities
{
    public class PublicationEntity : Entity
    {
        public string Title { get; set; }
        // Additional publication information as needed

        public List<CustomerSubscriptionEntity> Subscriptions { get; set; }
        public List<DistributionCompanyEntity> DistributionCompanies { get; set; }
    }

}
