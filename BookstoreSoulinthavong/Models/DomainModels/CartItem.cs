using BookstoreSoulinthavong.Models.DTO;
using System.Text.Json.Serialization;

namespace BookstoreSoulinthavong.Models.ExtensionMethods
{
    public class CartItem
    {
        public BookDTO Book { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public double Subtotal => Book.Price * Quantity;
    }
}