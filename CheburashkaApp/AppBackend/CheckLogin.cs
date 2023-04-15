
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheburashkaApp
{
    static class CheckLogin
    {
        public static bool CheckInSystem()
        {
            bool DEBUG_MODE = false; //убрать после полной отладки меню входа
            if (DEBUG_MODE) { return false; }
            UserDataIO userDataIO = new UserDataIO();
            string userdata = userDataIO.ReadFromFile();
            if (userdata == null)
            {
                return false;
            }
            else
            {
                string login = Encryptor.DecryptLogin(userdata);
                string password = Encryptor.DecryptPassword(userdata);
                return CheckInServer(login, password);
            }
        }
        public static bool CheckInServer(string login,string password)
        {
            if (login == "localhost" && password == "12345") //временная затычка проверки логина и пароля
            {
                return true;
            }//надо сделать
            else return false;
        }
    }
}
