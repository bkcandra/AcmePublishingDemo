using Ardalis.SmartEnum;

namespace AcmePublishingDemo.Infrastructure.Config
{
    public class AppRegion : SmartEnum<AppRegion>
    {
        public string[] Environment { get; }

        public AppRegion(int key, string value, string[] environment) : base(value, key)
        {
            this.Environment = environment;
        }

        public static AppRegion US = new AppRegion(1, "US", new[] { AppEnvironment.Development, AppEnvironment.Staging, AppEnvironment.Production });
        public static AppRegion AU = new AppRegion(2, "AU", new[] { AppEnvironment.Development, AppEnvironment.Staging, AppEnvironment.Production });
        public static AppRegion EU = new AppRegion(3, "EU", new[] { AppEnvironment.Development, AppEnvironment.Production });
        public static AppRegion GB = new AppRegion(4, "GB", new[] { AppEnvironment.Development, AppEnvironment.Production });

        public static AppRegion TestRegion = new AppRegion(-999, nameof(TestRegion), new[] { AppEnvironment.Test });
        public static AppRegion TestRegion2 = new AppRegion(-1000, nameof(TestRegion2), new[] { AppEnvironment.Test });

        public static AppRegion SchedulerTestRegion = new AppRegion(5, nameof(SchedulerTestRegion), new[] { "SchedulerTest" });

        public static bool TryFromString(string name, out AppRegion result)
        {
            return TryFromString(name, true, out result);
        }

        public static bool TryFromString(string name, bool ignoreCase, out AppRegion result)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (ignoreCase)
            {
                return _fromStringIgnoreCase.Value.TryGetValue(name, out result);
            }
            else
            {
                return _fromString.Value.TryGetValue(name, out result);
            }
        }

        public static IReadOnlyCollection<AppRegion> CurrentEnvList =>
            List.Where(x => x.Environment.Contains(AppEnvironment.CurrentEnvirontment)).OrderBy(t => t.Name).ToList().AsReadOnly();

        protected static readonly Lazy<Dictionary<string, AppRegion>> _fromString =
          new Lazy<Dictionary<string, AppRegion>>(() => CurrentEnvList.ToDictionary(item => item.Name));

        protected static readonly Lazy<Dictionary<string, AppRegion>> _fromStringIgnoreCase =
            new Lazy<Dictionary<string, AppRegion>>(() => CurrentEnvList.ToDictionary(item => item.Name, StringComparer.OrdinalIgnoreCase));
    }
}
