
namespace wctc.edu
{
    public class FileInput
    {
        private StreamReader _reader = null;
        private string _fileName;

        public FileInput(string fileName)
        {
            _fileName = fileName;
            try
            {
                _reader = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + _fileName + " " + e);
            }
        }

        public void FileRead()
        {
            try
            {
                string line;
                while ((line = _reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + _fileName + " " + e);
            }
        }

        public string FileReadLine()
        {
            try
            {
                return _reader.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + _fileName + " " + e);
                return null;
            }
        }

        public void FileClose()
        {
            if (_reader != null)
            {
                try
                {
                    _reader.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
