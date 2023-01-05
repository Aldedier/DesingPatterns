using System;
using System.IO;

namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;

        private string path;

        public static Log GetInstance(string _path)
        {
            if (_instance == null)
            {
                _instance = new Log(_path);
            }

            return _instance;
        }

        private Log(string _path)
        {
            path = _path;
        }

        public void Save(string _message)
        {
            File.AppendAllText(path, _message + Environment.NewLine);
        }

    }
}
