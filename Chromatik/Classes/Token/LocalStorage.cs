using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromatik.Classes.Token
{
    public static class Storage
    {
        public static string token = "";
        public static User auth = null;
        public static void setToken(string token)
        {
            Storage.token = token;
        }

        public static string getToken()
        {
            return token;
        }
        public static void setUser(User user)
        {
            Storage.auth = user;
        }
        public static User getUser()
        {
               return auth;
        }
    }
}
