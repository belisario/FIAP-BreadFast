using System.Collections.Generic;

namespace WebAPI_Produto.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string TimeToArrive { get; set; }
        public string TotalValue { get; set; }
        public IList<ProductsOrder> products { get; set; }
    }
}