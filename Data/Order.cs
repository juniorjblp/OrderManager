using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCpf { get; set; }
        public string CreateDate { get; set; }
        public string Value { get; set; }
        public string Status { get; set; }
        public List<Product> Products { get; set; }
        public string FullName => $"{CustomerFirstName} {CustomerLastName}";
    }
}
