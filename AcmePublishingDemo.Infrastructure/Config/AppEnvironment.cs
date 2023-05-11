namespace AcmePublishingDemo.Infrastructure.Config
{
    public class AppEnvironment
    {
        public static string CurrentEnvirontment { get; set; }
        public static bool IsDevelopment { get; set; }

        public const string Test = "Test";
        public const string Development = "Development";
        public const string Staging = "Staging";
        public const string Production = "Production";

        public static string GetConnectionStringName(AppRegion region, string database = "")
        {
            return database.Length == 0 ? $"{region.Name}_{CurrentEnvirontment}_Connection" : $"{database}_{region.Name}_{CurrentEnvirontment}_Connection";
        }

        /// <summary>
        /// Generate configuration key for storage connection string
        /// 'DevelopmentStorage' point to Dev storage
        /// 'DEV_ProductionStorage' point to stable storage
        /// 'AU_ProductionStorage' point to AU storage
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public static string GetStorageSecretKey(AppRegion region)
        {
            return $"{region.Name}_Storage_{AppEnvironment.CurrentEnvirontment}";
        }
    }
}
