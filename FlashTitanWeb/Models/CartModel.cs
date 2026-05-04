using System.ComponentModel.DataAnnotations;

namespace FlashTitanWeb.Models
{
    public class CartModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public UserModel User { get; set; }
        public ICollection<CartItemModel> CartItems { get; set; }
    }
}
