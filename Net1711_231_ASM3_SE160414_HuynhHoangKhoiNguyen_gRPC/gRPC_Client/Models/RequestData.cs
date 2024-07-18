namespace gRPC_Client.Models
{
    public class RequestData
    {
        public class RequestDataCategory
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string? httpMethod { get; set; }

        }

        public class RequestDataProduct
        {
            public int ProductId { get; set; }
            public int AccountId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }
            public int QuantityInStock { get; set; }
            public string? Description { get; set; }
            public string? Status { get; set; }
            public string CreatedDate { get; set; }
            public string UpdatedDate { get; set; }
            public int TotalRating { get; set; }
            public string? httpMethod { get; set; }

        }
    }
}
