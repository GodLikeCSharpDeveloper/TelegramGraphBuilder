using TelegramChatGraphBuilder.Models;

namespace TelegramChatGraphBuilder.DiagramService
{
    public class DiagramServiceGrouper
    {
        public async Task<List<DiagramMessageModel>> GroupMessagesByDateAndSender(List<Message> messages)
        {
            try
            {
                var groupedData = messages
              .GroupBy(m => new
              {
                  Year = DateTime.Parse(m.Date).Year,
                  Month = DateTime.Parse(m.Date).Month,
                  m.From
              })
              .Select(g => new DiagramMessageModel
              {
                  YearMonth = $"{g.Key.Year}-{g.Key.Month}",
                  From = g.Key.From,
                  Count = g.Sum(x =>
                  {
                      int value = 0;
                      if (x!=null && !string.IsNullOrEmpty(x.Text))
                          value = x.Text.Count();
                      return value;
                  })
              })
              .OrderBy(g => g.YearMonth)
              .ThenBy(g => g.From)
              .ToList();

                return groupedData.Where(x=>!string.IsNullOrEmpty(x.From)).ToList();
            }
            catch
            {
                throw;
            }
          
        }
    }
}
