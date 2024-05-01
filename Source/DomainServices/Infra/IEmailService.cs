using Domain;
using Domain.Models.Api;

namespace DomainServices.Infra;

public interface IEmailService
{
    Task<FrameworkResult> SendEmailAsync(NotificationInfoModel message);
}