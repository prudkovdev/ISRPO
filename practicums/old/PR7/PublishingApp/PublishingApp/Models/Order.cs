using System;

namespace PublishingApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
        public DateTime OrderDate { get; set; }
        public string CompletionDate { get; set; }
        public decimal Price { get; set; }
    }
}
