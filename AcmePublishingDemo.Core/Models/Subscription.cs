namespace AcmePublishingDemo.Core.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public int CustomerId { get; set; }
        public int PublicationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
