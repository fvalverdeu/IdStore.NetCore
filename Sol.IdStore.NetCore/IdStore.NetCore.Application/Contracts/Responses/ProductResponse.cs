using System;
using System.Collections.Generic;
using System.Text;

namespace IdStore.NetCore.Application.Contracts.Responses
{
    public class ProductResponse
    {
        public int IdProduct { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string Expiration { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Status { get; set; }
        public int IdMaker { get; set; }
        public int IdCategory { get; set; }
    }

    public class CustomResponse<T>
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

    public class CustomResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
