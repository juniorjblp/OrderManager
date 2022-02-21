using Data;
using Infra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvcOrder
    {
        public static List<Order> ListOrder()
        {
            try
            {
                var OrderList = new List<Order>(new OrderDAO().ListOrders().Rows.Count);

                foreach (DataRow row in new OrderDAO().ListOrders().Rows)
                {
                    var values = row.ItemArray;

                    var order = new Order()
                    {
                        Id = Convert.ToInt32(values[0]?.ToString() ?? string.Empty),
                        CustomerId = Convert.ToInt32(values[1]?.ToString() ?? string.Empty),
                        CustomerFirstName = values[2]?.ToString() ?? string.Empty,
                        CustomerLastName = values[3]?.ToString() ?? string.Empty,
                        CustomerCpf = values[4]?.ToString() ?? string.Empty,
                        CreateDate = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:dd/MM/yyyy - HH:mm}", Convert.ToDateTime(values[5]?.ToString() ?? string.Empty)),
                        Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDouble(values[6]?.ToString() ?? string.Empty)),
                        Status = values[7]?.ToString() ?? string.Empty
                    };

                    OrderList.Add(order);
                }
                return OrderList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Product> ListOrderProduct(int orderid)
        {
            try
            {
                var productList = new List<Product>(new ProductDAO().ListProduct().Rows.Count);

                foreach (DataRow row in new OrderDAO().ListOrdersProducts(orderid).Rows)
                {
                    var values = row.ItemArray;

                    var product = new Product()
                    {
                        Id = Convert.ToInt32(values[0]?.ToString() ?? string.Empty),
                        Name = values[1]?.ToString() ?? string.Empty,
                        Category_id = Convert.ToInt32(values[2]?.ToString() ?? string.Empty),
                        Category = values[3]?.ToString() ?? string.Empty,
                        Quantity = Convert.ToInt32(values[4]?.ToString() ?? string.Empty),
                        Value = values[5]?.ToString() ?? string.Empty
                    };

                    productList.Add(product);
                }
                return productList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DeleteOrder(int id)
        {

            try
            {
                return new OrderDAO().DeleteOrder(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool InsertOrder(int customerid, double value, int status)
        {
            try
            {
                return new OrderDAO().InsertOrder(customerid, value, status);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool InsertProductOrder(int orderid, int productid)
        {
            try
            {
                return new OrderDAO().InserProductOrder(orderid, productid);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
