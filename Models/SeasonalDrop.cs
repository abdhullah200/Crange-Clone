namespace carnage.Models
{
    public class SeasonalDrop
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Colors { get; set; } = string.Empty;
        public string Sizes { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl1 { get; set; } = string.Empty;
        public string ImageUrl2 { get; set; } = string.Empty;
        public string SeasonName { get; set; } = string.Empty;
    }
}