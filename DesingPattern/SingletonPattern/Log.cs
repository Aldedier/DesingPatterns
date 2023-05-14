using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.SingletonPattern
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";

        public static Log Instance { get => _instance; }

        private Log()
        {
                
        }

        public void Save(string _message)
        {
            File.AppendAllText(_path, _message + Environment.NewLine);
        }

        public string Read()
        {
            return File.ReadAllText(_path);
        }
    }
}
