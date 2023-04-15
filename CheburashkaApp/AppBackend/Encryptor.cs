using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheburashkaApp
{
    static class Encryptor
    {
        public static string Encrypt(string login,string password)
        {
            return login + '/' + password;
        }
        public static string DecryptLogin(string userdata) 
        {
            return userdata.Substring(0, userdata.IndexOf('/'));
        }
        public static string DecryptPassword(string userdata) 
        {
            return userdata.Substring(userdata.IndexOf('/') + 1);
        }
    }
}
