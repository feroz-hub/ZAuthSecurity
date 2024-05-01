using Domain;
using Domain.Models.Api;

namespace DomainServices.Infra;

/// <summary>
/// Interface defining operations for sending emails.
/// </summary>
public interface IEmailService
{
    /// <summary>
    /// Sends an email asynchronously.
    /// </summary>
    /// <param name="message">The message containing email details.</param>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> SendEmailAsync(NotificationInfoModel message);
}
