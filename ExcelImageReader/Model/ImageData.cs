using System.Drawing;

namespace ExcelImageReader.Model
{
    public class ImageData
    {
        private int index;
        private string name;
        private string extension;
        private Image image;

        public ImageData(int index, string name, string extension, Image image)
        {
            this.index = index;
            this.name = name;
            this.extension = extension;
            this.image = image;
        }

        public int GetIndex()
        {
            return index;
        }

        public string GetName()
        {
            return name;
        }

        public string GetExtension()
        {
            return extension;
        }

        public Image GetImage()
        {
            return image;
        }
    }
}
