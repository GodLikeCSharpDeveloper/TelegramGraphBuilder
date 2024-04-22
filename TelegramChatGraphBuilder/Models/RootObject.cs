using System.Text.Json.Serialization;

namespace TelegramChatGraphBuilder.Models
{
    public class RootObject
    {
        [JsonPropertyName("messages")]
        public List<Message> Messages { get; set; }
    }
}
