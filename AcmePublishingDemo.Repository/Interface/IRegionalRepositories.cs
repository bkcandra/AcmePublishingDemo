using AcmePublishingDemo.Infrastructure.Config;

namespace AcmePublishingDemo.Repository.Interface
{
    public interface IRegionalRepositories
    {
        bool AppliesTo(AppRegion region);
    }


}
