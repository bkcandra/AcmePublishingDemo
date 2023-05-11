using AcmePublishingDemo.Repository.Models;

namespace AcmePublishingDemo.EF.Entities
{
    public class DistributionCompanyEntity : Entity
    {
        public string Name { get; set; }

        public string Country { get; set; }
        public string CountryCode { get; set; }
        // Additional properties for the print-distribution company

        public List<PublicationEntity> Publications { get; set; }

    }

}
