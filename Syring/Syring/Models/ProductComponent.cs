namespace Syring.Models
{
    public class ProductComponent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string FilePath { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
