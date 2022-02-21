using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;

namespace Services
{
    public class SvcUserLogin
    {
        UserDAO userDAO = new UserDAO();
        public bool LoginUser(string user, string pass)
        {
            return userDAO.DoLogin(user, pass);
        }
    }
}
