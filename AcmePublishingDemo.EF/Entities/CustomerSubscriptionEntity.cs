using AcmePublishingDemo.Repository.Models;

namespace AcmePublishingDemo.EF.Entities
{
    public class CustomerSubscriptionEntity : Entity
    {
        public long CustomerId { get; set; }
        public long PublicationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // Additional subscription information as needed

        public CustomerEntity Customer { get; set; }
        public PublicationEntity Publication { get; set; }
        public List<DeliveryAddressEntity> DeliveryAddresses { get; set; }
    }

}
