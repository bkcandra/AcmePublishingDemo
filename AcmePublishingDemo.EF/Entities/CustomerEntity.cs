using AcmePublishingDemo.Repository.Models;

namespace AcmePublishingDemo.EF.Entities
{
    /// <summary>
    /// Customer Entity
    /// </summary>
    public class CustomerEntity : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        // Additional customer information as needed

        public List<CustomerSubscriptionEntity> Subscriptions { get; set; }
    }

}
