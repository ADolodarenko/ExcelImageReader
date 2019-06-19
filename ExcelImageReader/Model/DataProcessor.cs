using System;
using System.Collections.Generic;

namespace ExcelImageReader.Model
{
    public class DataProcessor
    {
        private const string MESSAGE_IMAGE_PATTERN = "Image Index={0}, Name={1), Extension={2}: ";
        private const string MESSAGE_RESULT_PATTERN = "{0}: {1}";
        private const string MESSAGE_OK = "Successfully written.";

        private List<string> logLines;
        ExcelFileSource fileSource;
        ImageWriter imageWriter;

        public DataProcessor(string sourceFileName, string destFolderPath)
        {
            logLines = new List<string>();

            fileSource = new ExcelFileSource(sourceFileName);
            imageWriter = new ImageWriter(destFolderPath);
        }

        public void Process()
        {
            if (fileSource != null)
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

                    logLines.Add(message);
                }

                fileSource.Close();
            }
        }

        public List<string> GetLogLines()
        {
            return logLines;
        }
    }
}
