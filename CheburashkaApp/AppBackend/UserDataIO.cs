using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CheburashkaApp
{
    class UserDataIO
    {
        readonly string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"userdata.dat"); //здесь менять имя файла(но лучше не трогать)
        public void WriteToFile(string userdata)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (FileStream fs = File.Create(fileName)) { }
            File.WriteAllText(fileName, userdata);
        }
        public string ReadFromFile() 
        {
            if (!File.Exists(fileName))
            {
                return null;
            }
            else
            {
                return File.ReadAllText(fileName);
            }
        }
        public void DeleteFile()
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }
    }
}
