using System.Drawing;
using System.IO;

namespace ExcelImageReader.Model
{
    public class ImageWriter
    {
        private string destinationPath;

        public ImageWriter(string destinationPath)
        {
            this.destinationPath = destinationPath;
        }

        public void Write(ImageData imageData)
        {
            Image image = imageData.GetImage();

            string fileName = imageData.GetName() + "." + imageData.GetExtension();
            fileName = Path.Combine(destinationPath, fileName);

            image.Save(fileName);
        }
    }
}
