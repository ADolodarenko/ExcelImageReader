using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelImageReader.Model
{
    public class ImageLocators
    {
        private String url;
        private String name;
        private String extension;

        public ImageLocators(String url, String name, String extension)
        {
            this.url = url;
            this.name = name;
            this.extension = extension;
        }

        public String GetUrl()
        {
            return url;
        }

        public String GetName()
        {
            return name;
        }

        public String GetExtension()
        {
            return extension;
        }
    }
}
