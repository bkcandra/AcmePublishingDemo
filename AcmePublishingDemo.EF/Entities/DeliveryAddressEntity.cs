using AcmePublishingDemo.Repository.Models;

namespace AcmePublishingDemo.EF.Entities
{

    public class DeliveryAddressEntity : Entity
    {
        public long SubscriptionId { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        // Additional delivery address information as needed

        public CustomerSubscriptionEntity Subscription { get; set; }
    }

}
