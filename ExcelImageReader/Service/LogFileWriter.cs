using System.IO;

namespace ExcelImageReader.Service
{
    public class LogFileWriter
    {
        private StreamWriter writer;

        public LogFileWriter(string fileName)
        {
            writer = new StreamWriter(fileName);
        }

        public void WriteLine(string line)
        {
            writer.WriteLine(line);
        }

        public void Close()
        {
            if (writer != null)
            {
                writer.Close();

                writer = null;
            }
        }
    }
}
