namespace Project2024.Project2024.Models.Responses
{
    public class GetAllItemsByBrandResponse
    {
        public Brands Brands { get; set; }
        public List<Items> Items { get; set; }
    }
}
