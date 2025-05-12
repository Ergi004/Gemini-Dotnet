using GeminiChatBot.Models;

namespace GeminiChatBot.Services;
public interface IChatService
{
    Task<ChatResponseDto> SendMessageAsync(
        ChatRequestDto request,
        CancellationToken cancellationToken = default);

    Task<ChatHistoryDto?> GetHistoryAsync(int chatId, CancellationToken cancellationToken = default);

}