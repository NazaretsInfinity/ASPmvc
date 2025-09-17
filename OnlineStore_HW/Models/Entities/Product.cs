namespace OnlineStore_HW.Models.Entities
{
    public class Product
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
