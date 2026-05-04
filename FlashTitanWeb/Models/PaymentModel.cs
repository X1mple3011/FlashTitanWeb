using System.ComponentModel.DataAnnotations;

namespace FlashTitanWeb.Models
{
    public class PaymentModel
    {
        [Key]
        public int Id { get; set; }

        public string PaymentMethod { get; set; }
    }
}
