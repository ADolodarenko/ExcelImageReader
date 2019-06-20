using System;
using System.IO;
using ExcelImageReader.Service;

namespace ExcelImageReader.Model
{
    public class DataProcessor
    {
        private const string MESSAGE_LOG_NULL = "A method for adding to log must be specified.";
        private const string MESSAGE_IMAGE_PATTERN = "Image Index={0}, Name={1}, Extension={2}";
        private const string MESSAGE_RESULT_PATTERN = "{0}: {1}.";
        private const string MESSAGE_OK = "Successfully written";
        private const string LOG_FILE_NAME = "excelimagereader_log.txt";

        private Utils.AddToLogDelegate addToLogList;
        private ExcelFileSource fileSource;
        private ImageWriter imageWriter;
        private LogFileWriter logWriter;

        public DataProcessor(string sourceFileName, int imageNameColumn, string destFolderPath, string imageNameExtension, Utils.AddToLogDelegate addToLogList)
        {
            this.addToLogList = addToLogList ?? throw new Exception(MESSAGE_LOG_NULL);

            fileSource = new ExcelFileSource(sourceFileName, imageNameColumn, imageNameExtension);
            imageWriter = new ImageWriter(destFolderPath);
            logWriter = new LogFileWriter(Path.Combine(destFolderPath, LOG_FILE_NAME));
        }

        public void Process()
        {
            if (fileSource != null && logWriter != null)
            {
                fileSource.Open();

                ImageData imageData;
                string message;

                while ((imageData = fileSource.GetNextImageData()) != null)
                {
                    message = string.Format(MESSAGE_IMAGE_PATTERN,
                            imageData.GetIndex(), imageData.GetName(), imageData.GetExtension());

                    try
                    {
                        imageWriter.Write(imageData);

                        message = string.Format(MESSAGE_RESULT_PATTERN, message, MESSAGE_OK);
                    }
                    catch (Exception e)
                    {
                        message = string.Format(MESSAGE_RESULT_PATTERN, message, e.ToString());
                    }

                    logWriter.WriteLine(message);
                    addToLogList(message);
                }

                fileSource.Close();
                logWriter.Close();
            }
        }
    }
}
