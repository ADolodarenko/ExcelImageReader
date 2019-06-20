using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System;
using System.IO;

namespace ExcelImageReader.Model
{
    public class ExcelFileSource
    {
        private const string EX_PATTERN_FILE_NOT_EXISTS = "File '{0}' doesn't exist.";

        private string fileName;
        private int imageNameColumn;
        private string imageExtension;

        private ExcelPackage package;
        private ExcelWorksheet sheet;
        private int drawingIndex;

        public ExcelFileSource(string fileName, int imageNameColumn, string imageExtension)
        {
            this.fileName = fileName;
            this.imageNameColumn = imageNameColumn;
            this.imageExtension = imageExtension;
        }

        public void Open()
        {
            FileInfo fileInfo = new FileInfo(fileName);

            if (fileInfo.Exists)
            {
                package = new ExcelPackage(fileInfo);
                sheet = package.Workbook.Worksheets[1];
                drawingIndex = 0;
            }
            else
                throw new Exception(string.Format(EX_PATTERN_FILE_NOT_EXISTS, fileName));
        }

        public ImageData GetNextImageData()
        {
            if (drawingIndex < sheet.Drawings.Count)
            {
                ExcelDrawing drawing = sheet.Drawings[drawingIndex];

                int row = drawing.To.Row;
                string name = sheet.GetValue<string>(row + 1, imageNameColumn);

                ImageData data = new ImageData(drawingIndex, name, imageExtension, ((ExcelPicture) drawing).Image);

                drawingIndex++;

                return data;
            }
            else
                return null;
        }

        public void Close()
        {
            if (package != null)
            {
                package.Dispose();

                package = null;
            }
        }
    }
}
