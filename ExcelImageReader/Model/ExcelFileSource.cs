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
        private int urlColumn;
        private string imageExtension;

        private ExcelPackage package;
        private ExcelWorksheet sheet;
        private int drawingIndex;
        private int currentRow;

        public ExcelFileSource(string fileName, int imageNameColumn, int urlColumn, string imageExtension)
        {
            this.fileName = fileName;
            this.imageNameColumn = imageNameColumn;
            this.urlColumn = urlColumn;
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
                currentRow = sheet.Dimension.Start.Row;
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

        public ImageLocators GetNextImageLocators()
        {
            if (currentRow <= sheet.Dimension.End.Row)
            {
                string url = GetCellText(currentRow, urlColumn);
                string name = GetCellText(currentRow, imageNameColumn);
                string extension = this.imageExtension;
                                
                string existingExt = Path.GetExtension(url);

                if ( !String.IsNullOrWhiteSpace(existingExt) )
                    extension = existingExt.Substring(1);
                
                currentRow++;

                return new ImageLocators(url, name, extension);
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

        private string GetCellText(int row, int column)
        {
            string value;

            try
            {
                value = sheet.GetValue<string>(row, column);
            }
            catch (Exception e)
            {
                value = sheet.Cells[row, column].Text;
            }

            return value;
        }
    }
}
