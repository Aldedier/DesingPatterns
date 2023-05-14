using System;
using System.IO;

namespace Tools
{
    /// <summary>
    /// Sealed (Sellado) es para que la clase no se pueda heredar
    /// </summary>
    public sealed class Log
    {
        private static Log _instance = null;
        private string path;
        private static object _protect = new object();

        public static Log GetInstance(string _path)
        {
            ///lock se utiliza para proteger que se creen mas instancias en metodo async
            lock (_protect)
                _instance ??= new Log(_path);

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
