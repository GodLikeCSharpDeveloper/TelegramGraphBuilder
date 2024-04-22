using System.Text.Json.Serialization;
using TelegramChatGraphBuilder.JsonService;

namespace TelegramChatGraphBuilder.Models
{
  
    public class Message
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("date_unixtime")]
        public string DateUnixtime { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("from_id")]
        public string FromId { get; set; }

        [JsonPropertyName("text")]
        [JsonConverter(typeof(CustomJsonConverter))]
        public string Text { get; set; }

        [JsonPropertyName("text_entities")]
        public List<PlainTextModel> TextEntities { get; set; }
    }
}
