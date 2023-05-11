using AcmePublishingDemo.Infrastructure.Config;
using AcmePublishingDemo.Repository.Interface;

namespace AcmePublishingDemo.EF.Repositories
{
    public class BaseRepositories : IRepositories
    {
        public virtual bool AppliesTo(AppRegion region)
        {
            throw new NotImplementedException();
        }

        public void Initiliase(AppRegion region)
        {
            //var conStrings = Singleton<RegionConnectionStrings>.Instance;

            //if (!conStrings.ConnectionStrings.ContainsKey(region.Name))
            //    throw new NotImplementedException($"The connection string '{region.Name}' is not yet implemented");

            //var connStr = conStrings.ConnectionStrings[region.Name];
            //var optionsBuilder = new DbContextOptionsBuilder<AccountEFContext>();
            //optionsBuilder.UseSqlServer(connStr);
            //Context = new AccountEFContext(optionsBuilder.Options);
        }
    }
}