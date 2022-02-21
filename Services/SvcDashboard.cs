using Infra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvcDashboard
    {
        public static Int64 CustumersCount()
        {
            try
            {
                return new DashboardDAO().CustumersCount();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Int64 ProductsCount()
        {
            try
            {
                return new DashboardDAO().ProductsCount();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Int64 OdersCount()
        {
            try
            {
                return new DashboardDAO().OdersCount();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string OrderValueCount()
        {
            try
            {
                return new DashboardDAO().OderValueCount();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable LowStockProductsCount()
        {
            try
            {
                return new DashboardDAO().LowStockProductsCount();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
