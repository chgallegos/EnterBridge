using System;

namespace EnterBridgeApp.Models {
    public class Order {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime SubmittedAt { get; set; }
        public string SubmittedBy { get; set; } = "User1";
    }
}
