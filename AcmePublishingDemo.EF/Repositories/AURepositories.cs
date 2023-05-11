using AcmePublishingDemo.Infrastructure.Config;

namespace AcmePublishingDemo.EF.Repositories
{
    public class AuRepositories : BaseRepositories
    {
        public AuRepositories()
        {
            Initiliase(_region);
        }

        private AppRegion _region => AppRegion.AU;



        public override bool AppliesTo(AppRegion region)
        {
            return region == _region;
        }
    }
}
