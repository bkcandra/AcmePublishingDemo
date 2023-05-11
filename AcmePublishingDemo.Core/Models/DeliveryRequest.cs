namespace AcmePublishingDemo.Core.Models
{
    public class DeliveryRequest
    {
        public int PrintRequestId { get; set; }
        public DateTime SentAt { get; set; }
        public int CustomerId { get; set; }
        public int DeliveryAddressId { get; set; }
    }
}
