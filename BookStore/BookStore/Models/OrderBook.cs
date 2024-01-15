namespace BookStore.Models
{
    public class OrderBook
    {
       
            public int Id { get; set; }
            public int BookId { get; set; }
            public string? CustomerId { get; set; }
            public int Quantity { get; set; }
            public float TotalAmount { get; set; }

        
        
    }
}
