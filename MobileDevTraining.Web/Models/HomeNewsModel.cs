namespace MobileDevTraining.Web.Models
{
    public class HomeNewsModel
    {
        public int HomeNewsId { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTimeOffset Timestamp { get; set; }
    }
}
