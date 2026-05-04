using System.ComponentModel.DataAnnotations;

namespace FlashTitanWeb.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public string DeliveryAddress { get; set; }
        public int PaymentId { get; set; }

        public UserModel User { get; set; }
        public PaymentModel Payment { get; set; }
        public ICollection<OrderDetailModel> OrderDetails { get; set; }
    }
}
