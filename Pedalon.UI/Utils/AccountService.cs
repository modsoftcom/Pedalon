using Pedalon.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalon.UI.Utils
{
    public static class AccountService
    {
        public static User Login(string username, string password)
        {
            try
            {
                Program.User = Service<User>.SingleSelectByQuery(u => u.Username == username && u.Password == password); 
                if(Program.User != null)
                {
                    Program.User.Logins.Add(DateTime.Now);
                    Service<User>.AddOrUpdate(Program.User);
                }
                return Program.User;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
