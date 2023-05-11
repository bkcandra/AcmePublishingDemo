using AcmePublishingDemo.Infrastructure.Config;

namespace AcmePublishingDemo.Repository.Interface
{
    /// <summary>
    /// Represents DB context
    /// </summary>
    public partial interface IDbContext
    {
        #region Methods

        /// <summary>
        /// Saves a set of entity changes in the repository as a single transaction
        /// </summary>
        /// <returns>The number of state entries written to the database</returns>
        Task<int> CommitAsync();

        /// <summary>
        /// initialise database
        /// </summary>
        void Initialise(AppRegion region);


        #endregion Methods
    }
}
