using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meridian
{
    public class Account
    {
        public string username;
        public string password;
        public decimal world;

        public void OnAccountLogin(object source, EventArgs args)
        {
            world = 62;
        }

    }
}
