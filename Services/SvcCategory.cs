using Data;
using Infra;
using System;
using System.Collections.Generic;
using System.Data;


namespace Services
{
    public class SvcCategory
    {
        public static List<Category> ListCategory()
        {
            try
            {
                var categoryList = new List<Category>(new CategoryDAO().ListCategory().Rows.Count);

                foreach (DataRow row in new CategoryDAO().ListCategory().Rows)
                {
                    var values = row.ItemArray;

                    var category = new Category()
                    {
                        Id = Convert.ToInt32(values[0]?.ToString() ?? string.Empty),
                        CategoryName = values[1]?.ToString() ?? string.Empty,
                    };

                    categoryList.Add(category);
                }
                return categoryList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override string ToString()
        {
            return ListCategory().ToString();
        }

        public static bool InsertCategory(string name)
        {
            CategoryDAO category = new CategoryDAO();

            Category cat = new Category();
            cat.CategoryName = name;
            try
            {
                return category.InsertCategory(name);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DeleteCategory(int id)
        {
            CategoryDAO category = new CategoryDAO();

            try
            {
                return category.DeleteCategory(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool UpdateCategory(int id, string name)
        {
            CategoryDAO category = new CategoryDAO();

            Category cat = new Category();
            cat.CategoryName = name;

            try
            {
                return category.UpdateCategory(id, name);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
