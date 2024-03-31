using System;
using System.IO;

namespace wctc.edu
{
    public class FileOutput
    {
        private StreamWriter _writer = null;
        private string _fileName;

        public FileOutput(string fileName)
        {
            _fileName = fileName;
            try
            {
                _writer = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + _fileName + " " + e);
            }
        }

        public void FileWrite(string line)
        {
            try
            {
                _writer.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + _fileName + " " + e);
            }
        }

        public void FileClose()
        {
            if (_writer != null)
            {
                try
                {
                    _writer.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
