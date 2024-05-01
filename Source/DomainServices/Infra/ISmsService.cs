using Domain;
using Domain.Models.Api;

namespace DomainServices.Infra;

/// <summary>
/// Interface defining operations for sending SMS messages and updating SMS status.
/// </summary>
public interface ISmsService
{
    /// <summary>
    /// Sends an SMS asynchronously.
    /// </summary>
    /// <param name="message">The message containing SMS details.</param>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> SensSmsAsync(NotificationInfoModel message);

    /// <summary>
    /// Updates the status of SMS messages asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> UpdateSmsStatusAsync();
}
