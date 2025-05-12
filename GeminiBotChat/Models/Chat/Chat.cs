using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeminiChatBot.Models;
public class Chat
{
    [Key]
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Prompt> Prompts { get; set; } = new List<Prompt>();
}
