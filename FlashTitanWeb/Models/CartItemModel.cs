using System.ComponentModel.DataAnnotations;

namespace FlashTitanWeb.Models
{
    public class CartItemModel
    {
        [Key]
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public CartModel Cart { get; set; }
        public ProductModel Product { get; set; }
    }
}
