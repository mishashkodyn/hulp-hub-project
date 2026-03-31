using Application.DTOs.AI;

namespace Infrastructure.Services.Interfaces
{
    public interface IAiService
    {
        Task<string> ChatAsync(AiChatRequestDto request);
    }
}
