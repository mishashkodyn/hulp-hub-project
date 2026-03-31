using Application.DTOs.Notifications;

namespace Infrastructure.Services.Interfaces
{
    public interface INotificationService
    {
        public Task SendNotificationAsync(CreateNotificationDto dto);
        public Task<IEnumerable<NotificationDto>> GetNotificationsByUserIdAsync(Guid userId, bool unreadOnly = false);
    }
}
