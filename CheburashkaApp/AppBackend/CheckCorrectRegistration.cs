
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheburashkaApp
{
    static class CheckCorrectRegistration
    {
        public const int minimumAge = 16; //минимальный возраст
        public static bool CheckAll(string login,string password1,string password2, string name, DateTime birthday)
        {
            if (login != null && password1 != null && password2 != null && name != null)
            {
                return CheckLoginFree(login) && CheckLoginCorrect(login) && CheckPasswordCorrect(password1) && CheckPasswordLength(password1) && CheckPasswordsSame(password1, password2) && CheckNameCorrect(name) && CheckAgeCorrect(birthday);
            }
            else { return false; }
        }
        public static bool CheckLoginFree(string login)
        {
            if (true)
            {
                return true; //прописать проверку наличия email на сервере
            }
            else return false;
        }
        public static bool CheckLoginCorrect(string login)
        {
            if (login.Length > 4)
            { //написать сервис проверки существования email
                return true;
            }
            else return false;
        }
        public static bool CheckPasswordLength(string password)
        {
            if (password.Length>5) 
            {
                return true;
            }
            else return false;
        }
        public static bool CheckPasswordCorrect(string password)
        {
            foreach (char c in password)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || c == '_'))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckPasswordsSame(string password1, string password2)
        {
            if (password1.Equals(password2))
            {
                return true;
            }
            else return false;
        }
        public static bool CheckNameCorrect(string name)
        {
            foreach (char c in name)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == ' ')) 
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckAgeCorrect(DateTime birthDate)
        {
            if (((DateTime.Now - birthDate).Days < minimumAge * 365)|| DateTime.Now<birthDate)
            {
                return false;
            }
            else return true;
        }
    }
}
