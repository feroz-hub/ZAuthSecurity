using Domain;

namespace DomainServices.Seed;

/// <summary>
/// Interface defining operations for creating seed data in the repository.
/// </summary>
public interface ISeedCreator
{
    /// <summary>
    /// Creates master data asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> CreateMasterDataAsync();

    /// <summary>
    /// Adds seed models asynchronously with a specified order number.
    /// </summary>
    /// <param name="orderNumber">The order number for the seed model.</param>
    /// <param name="model">The base model representing the seed data.</param>
    /// <returns>A task representing the asynchronous operation, returning a boolean indicating success.</returns>
    Task<bool> AddSeedModelsAsync(int orderNumber, BaseModel model);
}
