using System.ComponentModel.DataAnnotations;

namespace FlashTitanWeb.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public ICollection<OrderModel> Orders { get; set; }
        public ICollection<CartModel> Carts { get; set; }
    }
}
