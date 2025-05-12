// Models/ChatRequestDto.cs
using System.ComponentModel.DataAnnotations;

namespace GeminiChatBot.Models;
public class ChatRequestDto
{
    [Required]
    public int ChatId { get; set; }

    [Required]
    public string Prompt { get; set; } = string.Empty;
}
