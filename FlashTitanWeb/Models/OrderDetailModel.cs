using System.ComponentModel.DataAnnotations;

namespace FlashTitanWeb.Models
{
    public class OrderDetailModel
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public OrderModel Order { get; set; }
        public ProductModel Product { get; set; }
    }
}
