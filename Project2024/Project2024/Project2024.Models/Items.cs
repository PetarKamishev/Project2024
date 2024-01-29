namespace Project2024.Project2024.Models
{
    public class Items
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Brand { get; set; }   
        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
