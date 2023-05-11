namespace AcmePublishingDemo.Core.Models
{
    public class Publication
    {
        public int DistributionId { get; set; }
        public int PublicationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
    }
}
