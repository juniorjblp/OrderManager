using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Infra;

namespace Services
{
    public class SvcCustomers
    {
        public static List<Customer> ListCustomers()
        {
            try
            {
                var customerList = new List<Customer>(new CustomerDAO().ListCustomers().Rows.Count);

                foreach (DataRow row in new CustomerDAO().ListCustomers().Rows)
                {
                    var values = row.ItemArray;

                    var customer = new Customer()
                    {
                        Id = Convert.ToInt32(values[0]?.ToString() ?? string.Empty),
                        FirstName = values[1]?.ToString() ?? string.Empty,
                        LastName = values[2]?.ToString() ?? string.Empty,
                        Cpf = values[3]?.ToString() ?? string.Empty,
                        BirthDate = values[4]?.ToString() ?? string.Empty,
                        Email = values[5]?.ToString() ?? string.Empty
                    };

                    customerList.Add(customer);
                }
                return customerList;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static bool InsertCustomer(string firstname, string lastname, string cpf, string birthdate, string email)
        {

                CustomerDAO customer = new CustomerDAO();

                Customer person = new Customer();
                person.FirstName = firstname;
                person.LastName = lastname;
                person.Cpf = cpf;
                person.BirthDate = birthdate;
                person.Email = email;
            try
            {
                person.ValidateClasse();

                return customer.InsertCustomer(firstname, lastname, cpf, birthdate, email);
            }
            catch (Exception)
            {
                throw;
            }    
        }

        public static bool DeleteCustomer(int id)
        {
            CustomerDAO customer = new CustomerDAO();

            try
            {
                return customer.DeleteCustomer(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool UpdateCustomer(int id, string firstname, string lastname, string cpf, string birthdate, string email)
        {

                Customer person = new Customer();
                person.FirstName = firstname;
                person.LastName = lastname;
                person.Cpf = cpf;
                person.BirthDate = birthdate;
                person.Email = email;
            try
            {
                person.ValidateClasse();

                return new CustomerDAO().UpdateCustomer(id, firstname, lastname, cpf, birthdate, email);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
