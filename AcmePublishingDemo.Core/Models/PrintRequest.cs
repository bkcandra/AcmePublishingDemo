namespace AcmePublishingDemo.Core.Models
{
    public class PrintRequest
    {
        public int PublicationId { get; set; }
        public int DistributionCompanyId { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}
