using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class FileManager
    {
        private static FileManager _fileManager;
        private string _fileName;
        private StreamWriter _streamWriter;

        public static FileManager Instance
        {
            get
            {
                if (_fileManager == null)
                {
                    _fileManager = new FileManager();
                }
                return _fileManager;
            }
        }

        private FileManager()
        {
        }

        public void WriteToFile(string fileName, string content)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            _fileName = fileName + ".txt";

            _streamWriter = new StreamWriter(Path.Combine(path, _fileName), true);
            _streamWriter.WriteLine(content);
            _streamWriter.Flush();

        }
    }
}
