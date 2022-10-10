namespace Syring.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<ProductComponent> ProductComponents { get; set; }
    }
}
