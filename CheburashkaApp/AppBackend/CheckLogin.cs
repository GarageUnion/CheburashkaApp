﻿using System;
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
            return false;  //надо сделать
        }
        public static bool CheckInServer(string login,string password)
        {
            if (login == "localhost" && password == "12345")
            {
                return true;
            }//надо сделать
            else return false;
        }
    }
}
