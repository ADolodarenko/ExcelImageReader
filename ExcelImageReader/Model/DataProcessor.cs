using System;
using System.IO;
using System.Net;
using ExcelImageReader.Service;

namespace ExcelImageReader.Model
{
    public class DataProcessor
    {
        private const string MESSAGE_LOG_NULL = "A method for adding to log must be specified.";
        private const string MESSAGE_IMAGE_DATA_PATTERN = "Image Index={0}, Name={1}, Extension={2}";
        private const string MESSAGE_IMAGE_LOCATORS_PATTERN = "Image URL={0}, Name={1}, Extension={2}";
        private const string MESSAGE_RESULT_PATTERN = "{0}: {1}.";
        private const string MESSAGE_OK = "Successfully written";
        private const string LOG_FILE_NAME = "excelimagereader_log.txt";

        private ImageSourceType imageSourceType;
        private Utils.AddToLogDelegate addToLogList;
        private ExcelFileSource fileSource;
        private ImageWriter imageWriter;
        private LogFileWriter logWriter;

        public DataProcessor(ImageSourceType imageSourceType,
            string sourceFileName, int imageNameColumn, int urlColumn,
            string destFolderPath, string imageNameExtension, Utils.AddToLogDelegate addToLogList)
        {
            this.addToLogList = addToLogList ?? throw new Exception(MESSAGE_LOG_NULL);

            this.imageSourceType = imageSourceType;
            this.fileSource = new ExcelFileSource(sourceFileName, imageNameColumn, urlColumn, imageNameExtension);
            this.logWriter = new LogFileWriter(Path.Combine(destFolderPath, LOG_FILE_NAME));
            this.imageWriter = new ImageWriter(destFolderPath);
        }

        public void Process()
        {
            if (fileSource != null && logWriter != null)
            {
                fileSource.Open();

                if (this.imageSourceType == ImageSourceType.ExcelImage)
                    DownloadFromExcel();
                else
                    DownloadFromWeb();

                fileSource.Close();
                logWriter.Close();
            }
        }

        private void DownloadFromExcel()
        {
            ImageData imageData;
            string message;

            while ((imageData = fileSource.GetNextImageData()) != null)
            {
                message = string.Format(MESSAGE_IMAGE_DATA_PATTERN,
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
        }

        private void DownloadFromWeb()
        {
            ImageLocators imageLocators;
            string message;

            while ((imageLocators = fileSource.GetNextImageLocators()) != null)
            {
                message = string.Format(MESSAGE_IMAGE_LOCATORS_PATTERN,
                        imageLocators.GetUrl(), imageLocators.GetName(), imageLocators.GetExtension());

                try
                {
                    imageWriter.Write(imageLocators);

                    message = string.Format(MESSAGE_RESULT_PATTERN, message, MESSAGE_OK);
                }
                catch (Exception e)
                {
                    message = string.Format(MESSAGE_RESULT_PATTERN, message, e.ToString());
                }

                logWriter.WriteLine(message);
                addToLogList(message);
            }
        }
    }
}
