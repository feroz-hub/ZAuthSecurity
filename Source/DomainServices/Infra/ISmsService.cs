using Domain;
using Domain.Models.Api;

namespace DomainServices.Infra;

public interface ISmsService
{
    Task<FrameworkResult> SensSmsAsync(NotificationInfoModel message);
    Task<FrameworkResult> UpdateSmsStatusAsync();
}