using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FComManager
{
    public class UserClass
    {
        DatabaseClass db = new DatabaseClass();

        public Boolean isValidUser(string username, string password)
        {
            return db.isUserValid(username, password);
        }
    }
}
