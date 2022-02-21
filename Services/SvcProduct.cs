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
    public class SvcProduct
    {
        public static List<Product> ListProduct()
        {
            try
            {
                var productList = new List<Product>(new ProductDAO().ListProduct().Rows.Count);

                foreach (DataRow row in new ProductDAO().ListProduct().Rows)
                {
                    var values = row.ItemArray;

                    var product = new Product()
                    {
                        Id = Convert.ToInt32(values[0]?.ToString() ?? string.Empty),
                        Name = values[1]?.ToString() ?? string.Empty,
                        Category_id = Convert.ToInt32(values[2]?.ToString() ?? string.Empty),
                        Category = values[3]?.ToString() ?? string.Empty,
                        Quantity = Convert.ToInt32(values[4]?.ToString() ?? string.Empty),
                        Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", values[5]?.ToString() ?? string.Empty)
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

        public static bool InsertProduct(string name, int category_id, int quantity, string value)
        {
            try
            {
                ProductDAO product = new ProductDAO();

                Product prod = new Product();
                prod.Name = name;
                prod.Category_id = category_id;
                prod.Quantity = quantity;
                prod.Value = value;
                prod.ValidateClasse();

                return product.InsertProduct(name, category_id, quantity, value);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DeleteProduct(int id)
        {
            ProductDAO product = new ProductDAO();

            try
            {
                return product.DeleteProduct(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool UpdateProduct(int id, string name, int category_id, int quantity, string value)
        {
            try
            {
                ProductDAO product = new ProductDAO();

                Product prod = new Product();
                prod.Name = name;
                prod.Category_id = category_id;
                prod.Quantity = quantity;
                prod.Value = value;
                prod.ValidateClasse();

                return product.UpdateCustomer(id, name, category_id, quantity, value);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
